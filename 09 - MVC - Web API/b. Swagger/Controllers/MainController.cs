using Microsoft.AspNetCore.Mvc;

namespace MvcWebApi_Swagger.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MainController : ControllerBase
{
  [HttpGet]
  // 1. Use Swagger (200 is actually default)
  [ProducesResponseType(StatusCodes.Status200OK)]
  public ActionResult<IEnumerable<string>> Get()
  {
    return Ok(new List<string> { "one", "two", "three" });
  }

  [HttpPost]
  // 1. Use Swagger
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public IActionResult Post()
  {
    return BadRequest();
  }
}