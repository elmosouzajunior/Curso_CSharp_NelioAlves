using Secao10_Heranca.Entities;

namespace Secao10_Heranca.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; protected set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}
