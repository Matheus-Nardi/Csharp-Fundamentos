namespace Tipos_Nulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? numero = null;  //Para declarar um tipo nulo utiliza-se a ?
            Console.WriteLine("Escrevendo um número nulo");
            Console.WriteLine(numero);
            bool? liberadoAcesso;
            numero = 10;
            numero = 15;
            Console.WriteLine(numero);

            
           
          



            Console.ReadKey();
        }
    }
}