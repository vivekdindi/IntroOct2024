using Banking.Domain;

namespace Banking.Tests.Account;
public class NewAccounts
{
    // right balance opening

    [Fact]
    public void NewAccountsHaveCorrectOpeningBalance()
    {
        // write the code you wish you had
        //  Given (Arrange)
        var account = new BankAccount();
        //  When  ( Act)
        decimal balance = account.GetBalance();
        //  Then (Assert )
        Assert.Equal(5000M, balance);

    }

}
