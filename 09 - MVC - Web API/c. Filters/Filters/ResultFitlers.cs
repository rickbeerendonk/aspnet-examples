using Microsoft.AspNetCore.Mvc.Filters;

namespace MvcWebApi_Filters.Filters;

public class DemoResultFilterAttribute : Attribute, IResultFilter
{
  private readonly string name;

  public DemoResultFilterAttribute(string name)
  {
    this.name = name;
  }

  public void OnResultExecuting(ResultExecutingContext context)
  {
    Console.WriteLine($"DemoResultFilter.OnResultExecuting: {name}");
  }

  public void OnResultExecuted(ResultExecutedContext context)
  {
    Console.WriteLine($"DemoResultFilter.OnResultExecuted: {name}");
  }
}