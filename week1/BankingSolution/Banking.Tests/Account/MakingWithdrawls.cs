using Banking.Domain;

namespace Banking.Tests.Account;


public class MakingWithdrawls
{
    //    [Fact]
    //    public void Withdraw()
    //    {

    //        //given
    //        var account = new BankAccount();
    //        var openingBalance = account.GetBalance();

    //        var amountToWithDraw = 112.25M;

    //        //when

    //        account.Withdraw(amountToWithDraw);

    //        //then

    //        var balance = account.GetBalance();
    //        Assert.Equal(openingBalance - amountToWithDraw, balance);

    //    }


    [Theory]
    [InlineData(112.25)]
    [InlineData(30.25)]
    public void Withdraw(decimal amountToWithDraw)
    {

        //given
        var account = new BankAccount();
        var openingBalance = account.GetBalance();



        //when

        account.Withdraw(amountToWithDraw);

        //then

        var balance = account.GetBalance();
        Assert.Equal(openingBalance - amountToWithDraw, balance);

    }

    [Fact]

    public void CustomersCanTakeTheirFullBalance()
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();

        account.Withdraw(openingBalance);

        Assert.Equal(0, account.GetBalance());


    }

}
