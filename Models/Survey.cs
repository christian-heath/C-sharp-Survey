using System.ComponentModel.DataAnnotations;
namespace DojoSurvey.Models
{
    public class Survey
    {
        [Required]
        [MinLength(3)]
        [Display(Name = "Your Username:")]
        public string Name{get; set;}

        [Required]
        [Display(Name = "Dojo Location:")]
        public string DojoLocation{get;set;}


        [Required]
        [Display(Name = "Favorite Language:")]
        public string FavoriteLanguage{get; set;}


        [MaxLength(20)]
        [Display(Name = "Comment:")]
        public string Comment{get; set;}
    }
}