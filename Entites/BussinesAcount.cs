

namespace InicioHeranca.Entites
{
    public class BussinesAcount : Acount
    {
        public double LoanLimit { get; set; }

        public BussinesAcount()
        {
            
        }

        public BussinesAcount(int number, string holder, double balance, double loanLimit):base(number,holder,balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if(amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
