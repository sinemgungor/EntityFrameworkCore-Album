using DAL.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserDetailService
    {
        public UserDetailService()
        {
            _userDetailRepository=new UserDetailRepository(new DAL.Context.AppDbContext());
        }

        UserDetailRepository _userDetailRepository;


        // Kullanıcı adını getir
        public string GetName(int userId)
        {
            return _userDetailRepository.GetName(userId);
        }

        // Kullanıcı soyadını getir
        public string GetSurname(int userId)
        {
            return _userDetailRepository.GetSurname(userId);
        }
    }
}
