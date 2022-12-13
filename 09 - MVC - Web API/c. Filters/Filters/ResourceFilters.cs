using Microsoft.AspNetCore.Mvc.Filters;

namespace MvcWebApi_Filters.Filters;

public class DemoResourceFilterAttribute : Attribute, IResourceFilter
{
  private readonly string name;

  public DemoResourceFilterAttribute(string name)
  {
    this.name = name;
  }

  public void OnResourceExecuting(ResourceExecutingContext context)
  {
    Console.WriteLine($"DemoResourceFilter.OnResourceExecuting: {name}");
  }

  public void OnResourceExecuted(ResourceExecutedContext context)
  {
    Console.WriteLine($"DemoResourceFilter.OnResourceExecuted: {name}");
  }
}