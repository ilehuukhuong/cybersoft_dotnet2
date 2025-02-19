namespace Session28_BTVN.Models;

public class Transaction
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public DateTime Timestamp { get; set; }
    public string Type { get; set; } = "Deposit";
}
