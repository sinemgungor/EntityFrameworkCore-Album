using DAL.Repositories.Concrete;
using Models.Concretes;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserService
    {
        public UserService()
        {
            _userRepository=new UserRepository(new DAL.Context.AppDbContext());
        }

        UserRepository _userRepository;

        public bool Add(User user)
        {
            user.CreationDate = DateTime.Now;
            user.Status = Status.Active;

            return _userRepository.Add(user);
        }

        public bool Update(User user)
        {
            user.ModifiedDate = DateTime.Now;
            return _userRepository.Update(user);
        }

        public bool Delete(int id)
        {
            User user = GetById(id);
            return _userRepository.Delete(user);
        }

        public User GetById(int id)
        {
            return _userRepository.Find(id);
        }


        // Kullanıcı kontrolü
        public User ControlUser(string username, string password)
        {
            return _userRepository.Control(username, password);
        }

        // Kullanıcıyı kullanıcı kimliğine göre getirir
        public User GetUserByUserId(int userId)
        {
            return _userRepository.UserByUserId(userId);
        }

        // Kullanıcı adı ile kayıtlı kullanıcının varlığını kontrol eder
        public bool RegisterControl(string username)
        {
            return _userRepository.RegisterControl(username);
        }

        // Aktif kullanıcıları getirir
        public List<User> GetActiveUsers()
        {
            return _userRepository.GetUsers();
        }
    }
}
