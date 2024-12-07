using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var produtos = new List<ProdutoViewModel>
        {
            new ProdutoViewModel{Nome = "Perfume Capilar - Floral", Preco = 99.90, ImagemUrl = "/images/produto1.jpg" },
            new ProdutoViewModel { Nome = "Creme Hidratante", Preco = 59.90, ImagemUrl = "/images/produto2.jpg" },
            new ProdutoViewModel { Nome = "Óleo Capilar", Preco = 79.90, ImagemUrl = "/images/produto3.jpg" }
        };
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
