using eTicketsMovie.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace eTicketsMovie.Models
{
    public class Actor : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture URL")]
        [Required(ErrorMessage = "Profile Picture is Require")]
        public string ProfilePictureURL { get; set; }


        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is Require")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 to 50 characters")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }
        [Required(ErrorMessage = "Bio is Require")]

        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
