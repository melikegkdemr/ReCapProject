using Business.Abstarct;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            return new SuccessResult("Kullanıcı eklendi");
        }

        public IResult Delete(User user)
        {
            return new SuccessResult("Kullanıcı silindi");
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(),"Kullanıcılar listelendi");
        }

        public IDataResult<User> GetById(int userId)
        {
            return new SuccessDataResult<User>(_userDal.Get(u=>u.UserId == userId));
        }

        public IDataResult<List<UserDetailDto>> GetUserDetailDto()
        {
            return new SuccessDataResult<List<UserDetailDto>>(_userDal.GetUserDetails());
        }

        public IResult Update(User user)
        {
            return new SuccessResult("Kullanıcı güncellendi");
        }
    }
    
}
