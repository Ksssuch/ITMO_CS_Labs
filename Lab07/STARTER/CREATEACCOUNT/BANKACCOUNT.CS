
class BankAccount 
{
    private long accNo;
    private decimal accBal;
    private AccountType accType;

    public void Populate(long accNumber, decimal accBalance)
    {
        accNo = accNumber;
        accBal = accBalance;
        accType = AccountType.Checking;

    }

    public long getAccNo()
    {
        return accNo;
    }

    public decimal getAccBal()
    {
        return accBal;
    }

    public string getAccType()
    {
        return accType.ToString();
    }
}

