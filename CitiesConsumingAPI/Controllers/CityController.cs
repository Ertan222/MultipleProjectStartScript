using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitiesConsumingAPI.Data;
using CitiesLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CitiesConsumingAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CityController : ControllerBase
{
    private readonly CitiesDbContext _context;

    public CityController(CitiesDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("GetCities")]
    public async Task<IActionResult> GetCities() {
        List<City> x = await _context.Cities.ToListAsync();
        // HttpContext.Response.Cookies.Append("token", "Hey");
        return Ok(x);
    }
}
