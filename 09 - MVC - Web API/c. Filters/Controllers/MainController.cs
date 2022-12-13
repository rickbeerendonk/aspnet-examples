using Microsoft.AspNetCore.Mvc;

using MvcWebApi_Filters.Filters;

namespace MvcWebApi_Filters.Controllers;

[ApiController]
[Route("api/[controller]")]
[DemoActionFilter("Controller: Main")]
[DemoResourceFilter("Controller: Main")]
public class MainController : ControllerBase
{
  [HttpGet]
  [DemoActionFilter("Action: Get")]
  [DemoResourceFilter("Action: Get")]
  public ActionResult<IEnumerable<string>> Get()
  {
    return Ok(new List<string> { "one", "two", "three" });
  }
}