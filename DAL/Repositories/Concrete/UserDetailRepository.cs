using DAL.Context;
using Models.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Concrete
{
    public class UserDetailRepository : CRUD<UserDetail>
    {
        public UserDetailRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = new();
        }

        AppDbContext _dbContext;


        public string GetName(int userId)
        {
            var name = _dbContext.UserDetails
                .Where(x => x.User.UserID == userId)
                .Select(x => x.Name)
                .FirstOrDefault();
            return name;
        }


        public string GetSurname(int userId)
        {
            var surname = _dbContext.UserDetails
                .Where(x => x.User.UserID == userId)
                .Select(x => x.Surname)
                .FirstOrDefault();
            return surname;
        }
    }
}
