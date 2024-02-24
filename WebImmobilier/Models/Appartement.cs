using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebImmobilier.Models
{
    public class Appartement : Bien
    {
        [Display(Name = "Nombre de salle"), Required(ErrorMessage = "*")]
        public int NbreSalle { get; set; }
    }
}