using Microsoft.AspNetCore.Mvc;

namespace MvcWebApi_Basics.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MainController : ControllerBase
{
  [HttpGet]
  public ActionResult<IEnumerable<string>> Get()
  {
    return Ok(new List<string> { "one", "two", "three" });
  }
}