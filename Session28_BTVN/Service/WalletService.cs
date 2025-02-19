using Session28_BTVN.Models;

namespace Session28_BTVN.Service;

public class WalletService
{
    public decimal Balance { get; private set; } = 2500m;
    public List<Transaction> Transactions { get; private set; } = new();

    public event Action? OnBalanceChanged;

    public void Deposit(decimal amount)
    {
        if (amount <= 0) return;
        Balance += amount;
        Transactions.Add(new Transaction { Id = Transactions.Count + 1, Amount = amount, Type = "Deposit", Timestamp = DateTime.Now });
        OnBalanceChanged?.Invoke();
    }

    public bool Withdraw(decimal amount)
    {
        if (amount <= 0 || amount > Balance) return false;
        Balance -= amount;
        Transactions.Add(new Transaction { Id = Transactions.Count + 1, Amount = amount, Type = "Withdraw", Timestamp = DateTime.Now });
        OnBalanceChanged?.Invoke();
        return true;
    }
}
