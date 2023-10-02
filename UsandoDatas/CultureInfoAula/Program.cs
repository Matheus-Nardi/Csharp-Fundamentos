using System.Globalization;

namespace CultureInfoAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pegando as culturas / modelo
            var atual = CultureInfo.CurrentCulture;
            var pt = new CultureInfo("pt-BR");
            var enUs = new CultureInfo("en-US");
            var spain = new CultureInfo("es-ES");
            var german = new CultureInfo("de-De");
            var uk = new CultureInfo("en-UK");
            var russia = new CultureInfo("ru-RU");

            //Trabalhando os padrrõs de cada regiao  RegionInfo é uma classe
            var regiaoInfoBrazil = new RegionInfo("pt-BR");
            var regiaoInfoUs = new RegionInfo("en-US");

            Console.WriteLine(DateTime.Now.ToString("f" , enUs));

            //Mini-Pratica : Descobrindo as horas

            Console.WriteLine("Enter your country :");
            Console.WriteLine("1 - Brazil");
            Console.WriteLine("2 - UK");
            Console.WriteLine("3 - US");
            Console.WriteLine("4 - Spain");
            Console.WriteLine("5 - German");
            Console.WriteLine("6 - Russia");
            short op = short.Parse(Console.ReadLine());

            switch(op)
            {
                case 1: Console.WriteLine(DateTime.Now.ToString("f", pt)); Console.WriteLine("Currecy : {0}" ,regiaoInfoBrazil.CurrencyNativeName); break;
                case 2 : Console.WriteLine(DateTime.Now.ToString("f", uk)); break;
                case 3 : Console.WriteLine(DateTime.Now.ToString("f", enUs)); Console.WriteLine("Currecy : {0}", regiaoInfoUs.CurrencyNativeName); break;
                case 4 : Console.WriteLine(DateTime.Now.ToString("f", spain)); break;
                case 5 : Console.WriteLine(DateTime.Now.ToString("f", german)); break;
                case 6 : Console.WriteLine(DateTime.Now.ToString("f", russia)); break;
            }

            Console.ReadLine();
        }
    }
}