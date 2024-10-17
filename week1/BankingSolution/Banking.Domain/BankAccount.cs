


namespace Banking.Domain;

public class BankAccount
{
    public bool IsGold = false;
    private decimal _balance = 7000M;
    public virtual void Deposit(decimal amountToDeposit)
    {
        if (IsGold)
        {
            _balance += amountToDeposit * 1.10M;
        }
        else
        {
            _balance += amountToDeposit;
        }


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