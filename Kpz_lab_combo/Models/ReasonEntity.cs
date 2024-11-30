namespace Kpz_lab_combo.Models;

public class ReasonEntity
{
    public int Id { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
    public int EventId { get; set; }
    public HistoricalEventEntity? Event { get; set; }
}