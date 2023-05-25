using CleanHouse.PersistancyLayer;
using CleanHouse.PersistancyLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CleanHouse.Api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class HouseController : ControllerBase
  {
    private readonly AppDbContext _dbContext;

    public HouseController(AppDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    [HttpGet]
    public IEnumerable<House> GetHouses()
    {
      return _dbContext.Houses.AsNoTracking().ToList();
    }

    [HttpPost]
    public IActionResult CreateHouse([FromBody]House house)
    {
      if (house == null)
      {
        return BadRequest("House cannot be empty");
      }

      _dbContext.Houses.Add(house);
      _dbContext.SaveChanges();

      return Ok();
    }
  }
}
