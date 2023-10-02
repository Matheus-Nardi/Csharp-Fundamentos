namespace AddValores
{
    internal class Program
    {
        static void Main(string[] args)
        {
          var data = DateTime.Now;
            Console.WriteLine(data);

            //Faz o calculo automaticamente
            Console.WriteLine(data.AddDays(4));
            Console.WriteLine(data.AddMonths(5));
            Console.WriteLine(data.AddYears(2));

            Console.ReadKey();
        }
    }
}