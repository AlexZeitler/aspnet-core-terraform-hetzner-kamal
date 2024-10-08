using Microsoft.AspNetCore.Mvc;

namespace HelloAspNetCoreOnHetzner.Features.Subscriptions.GetOrganization;

public class GetOrganizationController : Controller
{
  [HttpGet("settings/organization")]
  public IActionResult GetOrganization(
  )
  {
    return View();
  }
}
