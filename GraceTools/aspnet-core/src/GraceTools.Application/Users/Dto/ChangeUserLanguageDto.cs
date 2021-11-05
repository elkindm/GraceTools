using System.ComponentModel.DataAnnotations;

namespace GraceTools.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}