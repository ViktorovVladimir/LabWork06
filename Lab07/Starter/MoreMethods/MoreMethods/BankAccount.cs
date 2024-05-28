
using System.Security.Principal;

class BankAccount
{
    long accNo;
    decimal accBal;
    AccountType accType;
    //--.
    static long nextAccNo = 123;

    //--.
    public void Populate( decimal balance )
    {
        this.accNo = NextNumber();
        this.accBal = balance;
        this.accType = AccountType.Checking;
    }

    //--.
    public long Number()
    {
        return accNo;
    }

    //--.
    public decimal Ballance()
    {
        return accBal;
    }

    //--.
    public string Type()
    {
        return accType.ToString();
    }

    //--.
    static long NextNumber()
    {
        return nextAccNo++;
    }

}