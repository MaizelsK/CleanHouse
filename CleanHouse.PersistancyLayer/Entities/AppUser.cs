using Microsoft.AspNetCore.Identity;

namespace CleanHouse.PersistancyLayer.Entities
{
  public class AppUser : IdentityUser<long>
  {
    public string FirstName { get; set; }

    public string LastName { get; set; }
  }
}
