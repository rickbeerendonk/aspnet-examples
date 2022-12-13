using Microsoft.AspNetCore.Mvc;

using MvcWebApi_Filters.Filters;

namespace MvcWebApi_Filters.Controllers;

[ApiController]
[Route("api/[controller]")]
[DemoActionFilter("Controller: Main")]
[DemoExceptionFilter("Controller: Main")]
[DemoResourceFilter("Controller: Main")]
[DemoResultFilter("Controller: Main")]
public class MainController : ControllerBase
{
  [HttpGet]
  [DemoActionFilter("Action: Get")]
  [DemoExceptionFilter("Action: Get")]
  [DemoResourceFilter("Action: Get")]
  [DemoResultFilter("Action: Get")]
  public ActionResult<IEnumerable<string>> Get()
  {
    Console.WriteLine("At: Action: Get");

    return Ok(new List<string> { "one", "two", "three" });
  }

  [HttpGet("fail")]
  [DemoActionFilter("Action: GetFail")]
  [DemoExceptionFilter("Action: GetFail")]
  [DemoResourceFilter("Action: GetFail")]
  [DemoResultFilter("Action: GetFail")]
  public IActionResult GetFail()
  {
    Console.WriteLine("At: Action: GetFail");

    throw new Exception("Failed!!!");
  }
}