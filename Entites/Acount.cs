

namespace InicioHeranca.Entites
{
    public class Acount
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }


        public Acount()
        {
            
        }

        public Acount(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Widthdraw(double amount)
        {
            Balance -= amount + 5.0;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
