using HelloAspNetCoreOnHetzner.Features.Account.Services;
using HelloAspNetCoreOnHetzner.Features.GetHome;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HelloAspNetCoreOnHetzner.Features.Account.Logoff;

public class LogOffController : Controller
{
  private readonly UserManager<AppUser> _userManager;
  private readonly SignInManager<AppUser> _signInManager;
  private readonly IEmailSender _emailSender;
  private readonly ISmsSender _smsSender;
  private readonly ILogger _logger;

  public LogOffController(
    UserManager<AppUser> userManager,
    SignInManager<AppUser> signInManager,
    IEmailSender emailSender,
    ISmsSender smsSender,
    ILoggerFactory loggerFactory
  )
  {
    _userManager = userManager;
    _signInManager = signInManager;
    _emailSender = emailSender;
    _smsSender = smsSender;
    _logger = loggerFactory.CreateLogger<LogOffController>();
  }


  [HttpGet("/signout")]
  public async Task<IActionResult> LogOff()
  {
    await _signInManager.SignOutAsync();
    _logger.LogInformation(4, "User logged out.");
    return RedirectToAction(nameof(GetHomeController.GetHome), "GetHome");
  }
}
