namespace Aula05.ativ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Obter os valores 
            Console.WriteLine("Digite o valor do produto: ");
            decimal valor = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a quantidade: ");
            int quantitade = Convert.ToInt32(Console.ReadLine());

            //Calcular
            //  Operadores: +(adição) -(subtração) *(multiplacação) /(divisão)  %(resto da divisão)
            decimal resultado = quantitade * valor;

            //Exibir
            Console.WriteLine("Total da compra: {0:c}", resultado);
            Console.ReadLine();
        }
    }
}