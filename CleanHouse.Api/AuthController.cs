using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanHouse.Api
{
  [Route("api/[controller]")]
  [ApiController]
  public class AuthController : ControllerBase
  {
    private readonly IHttpContextAccessor _httpContextAccessor;

    public AuthController(IHttpContextAccessor httpContextAccessor)
    {
      _httpContextAccessor = httpContextAccessor;
    }

    [HttpPost]
    public string Login(string username, string password)
    {
      //_httpContextAccessor.HttpContext.User.
      return "Authenticated!";
    }
  }
}
