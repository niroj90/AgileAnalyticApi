using System.ComponentModel.DataAnnotations;

namespace AgileInsights.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}