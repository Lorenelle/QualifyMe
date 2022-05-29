using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QualifyMe.DomainModels;
using QualifyMe.Repositories;
using QualifyMe.ViewModels;
using AutoMapper;
using AutoMapper.Configuration;

namespace QualifyMe.ServiceLayer
{
    public interface IStudentUsersService
    {
        int InsertStudentUser(RegisterViewModel uvm);
        
    }

    public class StudentUsersService : IStudentUsersService
    {
        IStudentUsersRepository ur;

        public StudentUsersService()
        {
            ur = new StudentUsersRepository();
        }

        public int InsertStudentUser(RegisterViewModel uvm)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<RegisterViewModel, StudentUser>(); cfg.IgnoreUnmapped(); });
            IMapper mapper = config.CreateMapper();
            StudentUser u = mapper.Map<RegisterViewModel, StudentUser>(uvm);
            u.PasswordHash = SHA256HashGenerator.GenerateHash(uvm.Password);
            ur.InsertStudentUser(u);
            int uid = ur.GetLatestStudentUserID();
            return uid;
        }
    }
}
