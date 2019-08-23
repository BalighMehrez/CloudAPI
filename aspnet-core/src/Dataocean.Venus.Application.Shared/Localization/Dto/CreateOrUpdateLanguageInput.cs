using System.ComponentModel.DataAnnotations;

namespace Dataocean.Venus.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}
