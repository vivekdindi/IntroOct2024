
namespace Banking.Domain;

public class BonusCalculator : ICalculateBonusForDeposits
{


    public decimal CalculateBonusForDepositOn(decimal balance, decimal amount)
    {
        return balance >= 5000 ? amount * 0.10M : 0;
    }
}