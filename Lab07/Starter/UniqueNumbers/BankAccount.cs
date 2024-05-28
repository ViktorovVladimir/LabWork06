
using System.Security.Principal;

class BankAccount
{
    long accNo;
    decimal accBal;
    AccountType accType;

    //--.
    public void Populate( long number, decimal balance )
    {
        this.accNo = number;
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

}