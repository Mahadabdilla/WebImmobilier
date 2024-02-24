using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebImmobilier.Models
{
    public class Utilisateur
    {
        [Key]
        public int IdUtilisateur { get; set; }

        [Display(Name = "Nom utilisateur "), Required(ErrorMessage = "*"), MaxLength(100)]
        public string NomUtil { get; set; }

        [Display(Name = "Prenom utilisateur "), Required(ErrorMessage = "*"), MaxLength(100)]
        public string PrenomUtil { get; set; }

        [Display(Name = "login utilisateur "), Required(ErrorMessage = "*"), MaxLength(100)]
        public string Login { get; set; }

        [Display(Name = " Password "), Required(ErrorMessage = "*"), MaxLength(100)]
        public string Pwd { get; set; }
    }
}