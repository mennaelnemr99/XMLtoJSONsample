using Microsoft.AspNetCore.Mvc;
using System.Xml;
using System.Text;
using Newtonsoft.Json;
[ApiController]
[Route("api/[controller]")]
public class LowFareController : ControllerBase
{
    private readonly ILogger<LowFareController> _logger;
    public LowFareController(ILogger<LowFareController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
        XmlDocument Doc = new XmlDocument();
        Doc.Load("1. lowfareSearch_request.xml");
        string Json = JsonConvert.SerializeXmlNode(Doc);
        OkObjectResult Result = Ok(Json);
        return Result;
    }
}