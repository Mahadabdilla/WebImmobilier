using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebImmobilier.Models
{
    public class Studio : Bien
    {
        [Display(Name = "Nombre de piece"), Required(ErrorMessage = "*")]
        public int NbreDePiece { get; set; }
    }
}