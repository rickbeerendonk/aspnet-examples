using Microsoft.AspNetCore.Mvc.Filters;

namespace MvcWebApi_Filters.Filters;

public class DemoActionFilterAttribute : Attribute, IActionFilter
{
  private readonly string name;

  public DemoActionFilterAttribute(string name)
  {
    this.name = name;
  }

  public void OnActionExecuting(ActionExecutingContext context)
  {
    Console.WriteLine($"DemoActionFilter.OnActionExecuting: {name}");
  }

  public void OnActionExecuted(ActionExecutedContext context)
  {
    Console.WriteLine($"DemoActionFilter.OnActionExecuted: {name}");
  }
}