


namespace Banking.Domain;

public class BankAccount(ICalculateBonusForDeposits calculater)
{
    //public bool IsGold = false;
    private decimal _balance = 7000M;
    //private ICalculateBonusForDeposits calculater;

    //public BankAccount(ICalculateBonusForDeposits calculater)
    //{
    //    this.calculater = calculater;
    //}

    public void Deposit(decimal amountToDeposit)
    {


        decimal bonus = calculater.CalculateBonusForDepositOn(_balance, amountToDeposit);

        _balance += amountToDeposit + bonus;


    }

    public decimal GetBalance()
    {
        return _balance;
    }

    public void Withdraw(decimal amountToWithdraw)
    {
        if (_balance >= amountToWithdraw)
        {
            _balance -= amountToWithdraw;
        }
        else
        {
            throw new AccountOverdraftException();
        }
    }
}

public class AccountOverdraftException : ArgumentOutOfRangeException;