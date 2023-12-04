using System.ComponentModel.DataAnnotations;

namespace App2tp6.Models.HotellerieModel
{
    public class Hotel
    {
        public int Id { get; set; }
        
        [Required (ErrorMessage = "Le champ Nom est obligatoire.")]
        [StringLength (20,MinimumLength =3,ErrorMessage = "La longueur du Nom doit être comprise entre 3 et 20 caractères.")]
        public string Name { get; set; }

        [Range(1, 5, ErrorMessage = "Le champ Etoiles doit avoir une valeur entre 1 et 5.")]
        public int Etoiles { get; set; }

        [Required(ErrorMessage = "Le champ Ville est obligatoire.")]
        public string Villes { get; set; }

        [Required(ErrorMessage = "Le champ Site Web est obligatoire.")]
        [RegularExpression(@"^(http|https)://([\w-]+.)+[\w-]+(/[\w- ./?%&=])?$", ErrorMessage = "Le champ Site Web doit contenir une URL valide.")]
        [Display(Name = "Site Web")]
        public string SiteWeb { get; set; }

        [StringLength(8)]
        public string Tel {  get; set; }


        public List<Appreciation> Appreciations { get; set; }

    }
}
