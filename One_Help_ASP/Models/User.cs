using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace One_Help_ASP.Models
{
    public class User
    {
        
        public int Id { get; set; }
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
       public string Password { get; set; }
       public string Statu { get; set; }
    } 
}
