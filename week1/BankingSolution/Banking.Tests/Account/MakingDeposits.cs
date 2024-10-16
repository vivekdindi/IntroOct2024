using Banking.Domain;

namespace Banking.Tests.Account;
public class MakingDeposits
{
    [Fact]
    public void MakingADepositIncreasesOurBalance()
    {
        //given
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        var amountToDeposit = 112.25M;

        //when
        account.Deposit(amountToDeposit);

        //then
        var endingBalance = account.GetBalance();
        Assert.Equal(amountToDeposit + openingBalance, endingBalance);


    }
}
