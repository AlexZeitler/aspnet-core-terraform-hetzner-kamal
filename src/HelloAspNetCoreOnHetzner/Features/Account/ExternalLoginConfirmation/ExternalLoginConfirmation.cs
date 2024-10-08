using System.ComponentModel.DataAnnotations;

namespace HelloAspNetCoreOnHetzner.Features.Account.ExternalLoginConfirmation;

public class ExternalLoginConfirmationViewModel
{
  [Required] [EmailAddress] public string Email { get; set; }
}
