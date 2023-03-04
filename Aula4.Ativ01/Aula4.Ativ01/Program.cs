namespace Aula4.Ativ01
{
    //Classe 
    internal class Program
    {
        //Metodo principal
        static void Main(string[] args)
        {
            //somar 2 numeros
            int num1;
            int num2;
            int soma;

            Console.WriteLine("Informe o primeiro numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o segundo numeoro: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            soma = num1 + num2;

            Console.WriteLine("A soma entre {0} + {1} é igual a {2}",num1,num2,soma);
            Console.ReadLine();
        }
    }
}