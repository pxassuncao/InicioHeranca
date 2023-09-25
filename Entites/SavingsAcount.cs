

namespace InicioHeranca.Entites
{
     class SavingsAcount : Acount
    {
        public double InterestRate { get; set; }
        public SavingsAcount()
        {
        }

        public SavingsAcount(int number, string holder, double balance,double interestRate): base(number,holder,balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
            
        }
        public override void Widthdraw(double amount)
        {
            Balance -= amount;
        }
    }
}
