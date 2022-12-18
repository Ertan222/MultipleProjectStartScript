using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using APIConsumeTry.Models;
using CitiesLibrary;
using System.Net.Http.Headers;
using APIConsumeTry.Data;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace APIConsumeTry.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly CitiesMvcDbContext _context;

    public HomeController(ILogger<HomeController> logger, CitiesMvcDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        List<City> x = new();
        HttpClient cities = new();
        cities.BaseAddress = new Uri("http://localhost:5274");

        cities.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        HttpResponseMessage Res = await cities.GetAsync("/api/City/GetCities");
        if (Res.IsSuccessStatusCode)
        {
            var Responsee = Res.Content.ReadAsStringAsync().Result;
            x = JsonConvert.DeserializeObject<List<City>>(Responsee);
        }

        // x = await _context.Cities.FirstOrDefaultAsync();
        // Deneme x = new();
        // x.Value = HttpContext.Request.Cookies.FirstOrDefault(a => a.Key == "hey").Value;

        return View(x);
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
