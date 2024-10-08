using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HelloAspNetCoreOnHetzner.Features.GetHome;

[Authorize]
public class GetHomeController(ILogger<GetHomeController> logger) : Controller
{
  private readonly ILogger<GetHomeController> _logger = logger;

  [HttpGet("/")]
  public IActionResult GetHome() => View();
}
