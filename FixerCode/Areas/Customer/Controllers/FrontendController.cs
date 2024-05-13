using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FixerCode.Areas.Customer.Controllers;

[Area("Customer")]
public class FrontendController : Controller
{
    private readonly ILogger<FrontendController> _logger;

    public FrontendController(ILogger<FrontendController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }



}
