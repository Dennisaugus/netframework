using System;

namespace Aula05.ativ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Obter valores
            Console.WriteLine("Digite o valor do produto: ");
            decimal valor = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine("Digite a quantidade de parcelas: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            //Calcular 
            decimal resultado = valor / quantidade;

            //Exibir 
            Console.WriteLine("o valor que será pago é de {0} R$ em {1} parcelas", resultado, quantidade);
            Console.ReadLine();
        }
    }
}