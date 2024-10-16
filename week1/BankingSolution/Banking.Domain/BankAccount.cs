﻿

namespace Banking.Domain;

public class BankAccount
{
    private decimal _balance = 5000M;


    public void Deposit(decimal amountToDeposit)
    {
        _balance += amountToDeposit;
    }

    public decimal GetBalance()
    {

        return _balance;
    }

    public void Withdraw(decimal amountToWithdraw)
    {
        if (_balance > amountToWithdraw)
        {

            _balance -= amountToWithdraw;
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }
    }


    public class AccountOverdraftException : ArgumentOutOfRangeException;



}