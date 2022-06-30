using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace One_Help_ASP.Models
{
    public class Benevole
    {
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        [DisplayName("Code Postal")]
        public int CodePostal { get; set; }
        [Required]
        [DisplayName("Telephone")]
        public string NumeroTel { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DisplayName("Mot de passe")]
        [DataType(DataType.Password)]
        public string Mdp { get; set; }
        public int Status { get; set; }
    }
}
