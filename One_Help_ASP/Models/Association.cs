using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace One_Help_ASP.Models
{
    public class Association
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Nom association")]
        public string NomAsso { get; set; }
        [Required]
        [DisplayName("Nom Representant Legal")]
        public string NomRepLegal { get; set; }
        [Required]
        [DisplayName("Adresse")]
        public string Adresse { get; set; }
        [Required]
        [DisplayName("CodePostal")]
        public int CodePostal { get; set; }
        [Required]
        [DisplayName("NumeroTel")]
        public string NumeroTel { get; set; }
        [Required]
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DisplayName("Mot de passe")]
        [DataType(DataType.Password)]
        public string Mdp { get; set; }
        public int Status { get; set; }
    }
}
