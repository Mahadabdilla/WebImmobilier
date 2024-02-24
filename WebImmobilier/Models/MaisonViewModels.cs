using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebImmobilier.Models
{
    public class MaisonViewModels
    {
        [Key]
        public int IdBien { get; set; }

        [Display(Name = "Description du bien"), Required(ErrorMessage = "*"), MaxLength(1000, ErrorMessage = "La taille maximale est de 1000")]
        public string DescriptionBien { get; set; }

        [Display(Name = "Superficie du bien")]
        public float? SuperficieBien { get; set; }

        [Display(Name = "Localite du bien"), Required(ErrorMessage = "*"), MaxLength(300, ErrorMessage = "La taille maximale est de 300")]
        public string LocaliteBien { get; set; }

        [Display(Name = "Nombre de salle d'eau "), Required(ErrorMessage = "*")]
        public int NbreSalleEau { get; set; }

        [Display(Name = "Nombre de cuisine"), Required(ErrorMessage = "*")]
        public int NbreCuisine { get; set; }

        [Display(Name = "Nombre de toilettes "), Required(ErrorMessage = "*")]
        public int? NbreToilette { get; set; }

        public int? IdProprio { get; set; }

        [ForeignKey("IdProprio")]

        public virtual Proprietaire Proprietaire { get; set; }

        [Display(Name = "Nombre de chambre"), Required(ErrorMessage = "*")]
        public int NbreChambre { get; set; }
    }
}