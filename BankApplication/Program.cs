namespace BankApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccountOwner owner = new AccountOwner(123456, "John", "Doe");
            AccountAdmin admin = new AccountAdmin(654321, "Jane", "Smith");

            Account account = new Account(owner, admin, 150);

            account.Deposit(50);
            account.Withdraw(30);
        }
    }
}
