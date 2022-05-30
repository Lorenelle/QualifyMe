using System;
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
                throw new NotImplementedException();
            }

            public void UpdateStudentUserPassword(StudentUser u)
            {
                throw new NotImplementedException();
            }

            public void DeleteStudentUser(int uid)
            {
                throw new NotImplementedException();
            }
        }
}
