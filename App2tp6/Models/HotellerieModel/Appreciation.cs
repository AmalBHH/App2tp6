using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App2tp6.Models.HotellerieModel
{
    public class Appreciation
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Le champ Nom Personne est obligatoire.")]
        [Display(Name = "Nom Personne")]
        public string NomPers { get; set; }


        [Required(ErrorMessage = "Le champ Commentaire est obligatoire.")]
        [DataType(DataType.MultilineText)]
        public string Commentaire { get; set; }

        [Required(ErrorMessage = "Le champ Note est obligatoire.")]
        [Range(1, 5, ErrorMessage = "La note doit être comprise entre 1 et 5.")]
        public int Note { get; set; }
        [Required(ErrorMessage = "L'ID de l'hôtel est obligatoire.")]
        [ForeignKey("Hotel")]


        public int HotelId { get; set; }

        public Hotel Hotel { get; set; }


    }
}
