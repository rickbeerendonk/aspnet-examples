using Microsoft.AspNetCore.Mvc.Filters;

namespace MvcWebApi_Filters.Filters;

public class DemoExceptionFilterAttribute : Attribute, IExceptionFilter
{
  private readonly string name;

  public DemoExceptionFilterAttribute(string name)
  {
    this.name = name;
  }

  public void OnException(ExceptionContext context)
  {
    Console.WriteLine($"DemoExceptionFilter.OnException: {name}");
  }
}