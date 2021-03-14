using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, MyDatabaseContext>, IUserDal
    {
        public List<UserDetailDto> GetUserDetails()
        {

            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                var result = from u in context.Users
                             join c in context.Customers
                             on u.UserId equals c.UserId
                             select new UserDetailDto
                             {
                                  CompanyName = c.CompanyName , FirstName = u.FirstName , LastName = u.LastName, UserId = u.UserId
                             };
                return result.ToList();


            }
        }
    }
}
