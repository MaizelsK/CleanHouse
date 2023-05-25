using Microsoft.EntityFrameworkCore;

namespace CleanHouse.PersistancyLayer.Entities
{
  public class Entity
  {
    public long Id { get; set; }

    public string Name { get; set; }

    public DateTime DateCreated { get; set; }
  }
}
