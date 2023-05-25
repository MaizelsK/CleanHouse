namespace CleanHouse.PersistancyLayer.Entities
{
  public class Space : Entity
  {
    public string? Description { get; set; }

    public int? FloorNumber { get; set; }

    public long HouseId { get; set; }

    public House? House { get; set; }

    public ICollection<SpaceElement> Elements { get; set; }
  }
}
