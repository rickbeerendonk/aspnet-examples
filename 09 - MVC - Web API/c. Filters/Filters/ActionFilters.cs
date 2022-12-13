using Microsoft.AspNetCore.Mvc.Filters;

namespace MvcWebApi_Filters.Filters;

public class DemoActionFilterAttribute : ActionFilterAttribute
{
  public string Name { get; set; } = "";

  public override void OnActionExecuting(ActionExecutingContext context)
  {
    Console.WriteLine($"DemoActionFilter.OnActionExecuting: {Name}");
  }

  public override void OnActionExecuted(ActionExecutedContext context)
  {
    Console.WriteLine($"DemoActionFilter.OnActionExecuted: {Name}");
  }
}