using Banking.Domain;

namespace Banking.Tests.Account;


public class MakingWithdrawls
{
    [Fact]
    public void Withdraw()
    {

        //given
        var account = new BankAccount();
        var openingBalance = account.GetBalance();

        var amountToWithDraw = 0;

        //when

        account.WithDraw(amountToWithDraw);

        //then

        var balance = account.GetBalance();
        Assert.Equal(openingBalance - amountToWithDraw, balance);

    }


}
