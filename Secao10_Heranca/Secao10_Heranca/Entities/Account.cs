namespace Secao10_Heranca.Entities
{
    class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder)
        {
            Number = number;
            Holder = holder;
        }

        public Account(int number, string holder, double balance) : this(number, holder)
        {
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }


    }


}
