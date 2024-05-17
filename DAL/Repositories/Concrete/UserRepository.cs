using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Models.Concretes;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Concrete
{
    public class UserRepository : CRUD<User>
    {
        public UserRepository(AppDbContext dbContext):base(dbContext) 
        {
            _dbContext = new();
        }

        AppDbContext _dbContext;


        public User Control(string username, string password)
        {
            return _dbContext.Users.Include(x => x.UserDetail).AsNoTracking().FirstOrDefault(x => x.UserName == username && x.Password == password);
        }

        public User UserByUserId(int userId)
        {
            return _dbContext.Users.FirstOrDefault(x => x.UserID == userId);
        }

        public bool RegisterControl(string username)
        {
            return _dbContext.Users.AsNoTracking().Any(x => x.UserName == username);
        }

        public List<User> GetUsers()
        {
            return _dbContext.Users.Where(x => x.Status == Status.Active).ToList();
        }
    }
   

}
