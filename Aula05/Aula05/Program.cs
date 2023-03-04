using System.Data;

namespace Aula05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipos Primitivos");

            string nome = "Dennis";
            short quantidade = 100;
            int numero = 123;
            long numerogrande = 12000000;
            Int32 teste = 12;

            byte item = 20;
            double comissao = 32.4544444;
            decimal valor = 1000; 

            decimal valor1 = Convert.ToDecimal(100.54);
            decimal valor2 = 100.45m;

            DateTime data = DateTime.Now;

            DateTime dataexemlo = new DateTime(2025, 12, 31);

            //Formatar

            Console.WriteLine("{0:D}", dataexemlo);
            Console.WriteLine("{0:d}", dataexemlo);
            Console.WriteLine("{0:ddd}", dataexemlo);
            Console.WriteLine("{0:dddd}", dataexemlo);

            Console.WriteLine("{0:c}", valor1);
            Console.ReadLine();



        }
    }
}