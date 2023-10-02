namespace Timespan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TimeSpan uma "unidade de medida para tempo"

            var timeSpanSegundos = new TimeSpan( 0 ,0, 20);
          
            var horaDeEntrada = new TimeSpan( 8 , 0 , 0 );
            var saida = new TimeSpan( 14 , 0 , 0 );

            double tempoDeTrabalho = (saida - horaDeEntrada).TotalHours;
            if( tempoDeTrabalho < 8 )
            {
                Console.WriteLine("Voce trabalhou menos de 8 horas ");
            }
            else
            {
                Console.WriteLine("Voce trabalhou mais de 8 horas ");
            }

            int hora, min = 0;
            hora = int.Parse(Console.ReadLine());
            min = int.Parse(Console.ReadLine());
            var inputUsuario = new TimeSpan( hora , min, 0 );
            Console.WriteLine(inputUsuario);
            Console.ReadLine();
        }
    }
}