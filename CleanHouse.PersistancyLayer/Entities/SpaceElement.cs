namespace CleanHouse.PersistancyLayer.Entities
{
  public class SpaceElement : Entity
  {
    public string? Description { get; set; }

    public int CleaningPeriodicity { get; set; }

    public DateTime? LastCleaned { get; set; }

    public long SpaceId { get; set; }

    public Space? Space { get; set; }
  }
}
