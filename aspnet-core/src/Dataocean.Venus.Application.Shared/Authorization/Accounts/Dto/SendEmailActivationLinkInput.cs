using System.ComponentModel.DataAnnotations;

namespace Dataocean.Venus.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}
