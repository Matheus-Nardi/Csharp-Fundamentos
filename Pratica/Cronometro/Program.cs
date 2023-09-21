using System.Collections.Specialized;

namespace Cronometro
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Menu();
        }

        static void Menu() 
        {
            Console.Clear();
            Console.WriteLine("S = Segundos => 10s = 10segundos");
            Console.WriteLine("M = Minutos => 1m = 1minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar ? ");

            string data = Console.ReadLine().ToLower();   //12s   data tem tamanho 2(porem so vai até o indice 1)  
            char type = char.Parse(data.Substring(data.Length-1 , 1)); // Para descobrir o ultimo digito passado 
            int time = int.Parse(data.Substring(0, data.Length-1)); // Pegar a parte númerica
            int mutiplier = 1;
            if(type == 'm')
                mutiplier = 60;

            if(time==0)
                System.Environment.Exit(0);

            PreStart(time * mutiplier); // Transformando se necessario
           

            Console.ReadKey();



        }
        static void PreStart(int time)
        {
            Console.WriteLine("Preparar...");
            Thread.Sleep(1000);
            Console.WriteLine("Apontar...");
            Thread.Sleep(1000);
            Console.WriteLine("Já...");
            Thread.Sleep(1050);

            Start(time);
        }
        static void Start(int time)
        {
            
            int currentTime = 0;

            while (currentTime != time) //Percorrer o nosso timer 
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000); // Faz com que o processador "durma" por 1seg , assim os números ficam visiveis
            }

            Console.Clear() ;
            Console.WriteLine("Cronometro Finalizado :)");
            Thread.Sleep(1500);
            Menu();
        }
    }
}