namespace CleanHouse.PersistancyLayer.Entities
{
  public class House : Entity
  {
    public string? Description { get; set; }

    public long UserId { get; set; }

    public AppUser? User { get; set; }

    public bool IsPrimary { get; set; }

    public ICollection<Space> Spaces { get; set; }
  }
}
