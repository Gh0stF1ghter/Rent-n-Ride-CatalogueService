namespace BLL.Models;

public record VchModel
{
    public Guid Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Vehicle? Vehicle { get; set; }
    public Client? Client { get; set; }
}
