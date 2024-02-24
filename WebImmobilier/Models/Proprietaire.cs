using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebImmobilier.Models;

namespace WebImmobilier.Models
{
    public class Proprietaire
    {
        [Key]
        public int IdProprio { get; set; }

        [Display(Name = "Nom du proprio "), Required(ErrorMessage = "*"), MaxLength(100)]
        public string NomProprio { get; set; }

        [Display(Name = "Prenom du proprio "), Required(ErrorMessage = "*"), MaxLength(100)]
        public string PrenomProprio { get; set; }

        public virtual ICollection<Bien> Proprietaires { get; set; }
    }
    
}