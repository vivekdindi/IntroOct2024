namespace Banking.Domain;

public interface ICalculateBonusForDeposits
{
    decimal CalculateBonusForDepositOn(decimal balance, decimal amount);
}