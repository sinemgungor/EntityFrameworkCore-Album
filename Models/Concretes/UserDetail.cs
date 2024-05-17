using Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concretes
{
    public class UserDetail:BaseEntity
    {
        [ForeignKey("User")]
        public int UserDetailID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        //navigation property
        public User? User { get; set; }
    }
}
