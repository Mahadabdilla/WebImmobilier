using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebImmobilier.Models
{
    public class Terrain : Bien
    {
        [Display(Name = "type de terrain"), Required(ErrorMessage = "*")]
        public int TypeTerrain { get; set; }
    }
}