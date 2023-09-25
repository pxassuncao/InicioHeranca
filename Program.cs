using InicioHeranca.Entites;


namespace InicioHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Acount acc = new Acount(1001,"Alex",0.0);
            BussinesAcount bacc = new BussinesAcount(1002,"Maria",0.0,1500.0);


            //UPCASTING (conversão da subclasse para superclasse)
            Acount acc1 = bacc;
            Acount acc2 = new BussinesAcount(1003,"Bob",0.0,500.0);
            Acount acc3 = new SavingsAcount(1004, "Ana", 0.0, 0.01);

            //DOWCASTING (conversão de superclasse para subclasse)
            BussinesAcount acc4 = (BussinesAcount) acc2;
            acc4.Loan(100.0);

            //BussinesAcount acc5 = (BussinesAcount) acc3;(erro de conversão)
            if(acc3 is BussinesAcount)
            {
                BussinesAcount acc5 = (BussinesAcount)acc3;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }
            if(acc3 is SavingsAcount)
            {
                Console.WriteLine("acc3 é um savings acount!");
            }
        }
    }
}