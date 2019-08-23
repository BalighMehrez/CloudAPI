using System.ComponentModel.DataAnnotations;

namespace Dataocean.Venus.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}

