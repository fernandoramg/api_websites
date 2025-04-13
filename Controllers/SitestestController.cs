using Microsoft.AspNetCore.Mvc;
using ApiTestFer.Models;

namespace ApiTestFer.Controllers;

[ApiController]
[Route("api/[controller]")]

public class WebSitesController : ControllerBase
{
    //Datos que se le enviarán en el endpoint
    private static readonly List<WebSites> websites = new()
    {
        new WebSites {Id = 1, Title = "OpenTec", Url = "https://opentec.com" },
        new WebSites {Id = 2, Title ="Google", Url= "https://www.google.com.mx"},
        new WebSites {Id = 3, Title = "Wikipedia", Url = "https://www.wikipedia.org"}
    };

    [HttpGet(Name = "GetWebSites")]
    public IActionResult Get()
    {
        return Ok(websites);
    }
}