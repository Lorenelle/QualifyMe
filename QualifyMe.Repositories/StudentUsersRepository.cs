using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QualifyMe.DomainModels;

namespace QualifyMe.Repositories
{
    
        public interface IStudentUsersRepository 
        {
            void InsertStudentUser(StudentUser u);
            void UpdateStudentUserDetails(StudentUser u);
            void UpdateStudentUserPassword(StudentUser u);
            void DeleteStudentUser(int uid);
            int GetLatestStudentUserID();

    }
        public class StudentUsersRepository : IStudentUsersRepository
        {
            QualifyMeDatabaseDbContext db;

            public StudentUsersRepository()
            {
                db= new QualifyMeDatabaseDbContext();
            }

            public void InsertStudentUser(StudentUser u)
            {
                db.StudentUsers.Add(u);
                db.SaveChanges();
            }

            public void UpdateStudentUserDetails(StudentUser u)
            {
                StudentUser us = db.StudentUsers.Where(temp => temp.UserID == u.UserID).FirstOrDefault();
                if (us != null)
                {
                    us.FirstName = u.FirstName;
                    us.LastName = u.LastName;
                    us.Mobile = u.Mobile;
                    db.SaveChanges();
                }
            }

            public void UpdateStudentUserPassword(StudentUser u)
            {
                    StudentUser us = db.StudentUsers.Where(temp => temp.UserID == u.UserID).FirstOrDefault();
                    if (us != null)
                    {
                        us.PasswordHash = u.PasswordHash;
                        db.SaveChanges();
                    }
            }

            public void DeleteStudentUser(int uid)
            {
                StudentUser us = db.StudentUsers.Where(temp => temp.UserID == uid).FirstOrDefault();
                if (us != null)
                {
                    db.StudentUsers.Remove(us);
                    db.SaveChanges();
                }
            }

            public int GetLatestStudentUserID()
            {
            int uid = db.StudentUsers.Select(temp => temp.UserID).Max();
            return uid;
            }
            
    }
}
