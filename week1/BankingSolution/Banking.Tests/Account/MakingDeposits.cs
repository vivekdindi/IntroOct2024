using Banking.Domain;

namespace Banking.Tests.Account;
public class MakingDeposits
{
    //[Fact]
    //public void MakingADepositIncreasesOurBalance()
    //{
    //    //given
    //    var account = new BankAccount();
    //    var openingBalance = account.GetBalance();
    //    var amountToDeposit = 112.25M;

    //    //when
    //    account.Deposit(amountToDeposit);

    //    //then
    //    var endingBalance = account.GetBalance();
    //    Assert.Equal(amountToDeposit + openingBalance, endingBalance);

    //}


    [Theory]
    [InlineData(112.25)]
    [InlineData(22.43)]
    [InlineData(22.23)]
    [InlineData(6000)]
    public void MakingADepositIncreasesOurBalance(decimal amountToDeposit)
    {
        //given
        var account = new BankAccount();
        var openingBalance = account.GetBalance();


        //when
        account.Deposit(amountToDeposit);


        //then
        var endingBalance = account.GetBalance();
        Assert.Equal(amountToDeposit + openingBalance, endingBalance);

    }

    //[Fact]
    //public void OverdraftIsAllowed()
    //{
    //    var account = new BankAccount();
    //    account.Withdraw ( account.GetBalance() + .01M );

    //    Assert.True(account.GetBalance() < 0);
    //}



    [Fact]
    public void OverdraftIsNotAllowed()
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();


        try
        {
            account.Withdraw(openingBalance + .01M);
        }
        catch (Exception)
        {

            throw;
        }

        Assert.Equal(openingBalance, account.GetBalance());
    }





}
