using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models.Concretes
{
    public class User:BaseEntity
    {
        public int UserID { get; set; }
        public string UserName  { get; set; }
        public string Password { get; set; }

        public UserDetail? UserDetail { get; set; }
    }
}
