using System.Globalization;

namespace TipoParaMoedas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal valor = 100.34m;
            var br = CultureInfo.CreateSpecificCulture("pt-BR");
            var en_US = CultureInfo.CreateSpecificCulture("en-US");
            var en_UK = CultureInfo.CreateSpecificCulture("en-UK");
            Console.WriteLine("{0}" , NumberFormatInfo.CurrentInfo.CurrencySymbol);
            Console.WriteLine(valor.ToString("C" , en_UK));
            Console.WriteLine(valor.ToString("C" , en_US));

            


           

            //Tipos de formatação
            /*  
             b = binario
             c= Moeda 
             d = decimal
             e = exponencial
             g = geral 
             p = porcentagem 
             x = hexadecimal
             
             
             
             */

            Console.ReadLine();
        }
    }
}