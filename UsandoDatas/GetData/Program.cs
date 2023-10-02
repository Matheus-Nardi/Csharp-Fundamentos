namespace GetData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = DateTime.Now;
            Console.WriteLine(data.ToString());
           
            var dataAniverario = new DateTime(2006, 8, 26);
            Console.WriteLine(data);
            //Acessando de maneira individual 
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Hour);
            Console.WriteLine(data.Minute);
            Console.WriteLine(data.Second);

            Console.WriteLine(data.DayOfYear);
            Console.WriteLine((int)data.DayOfWeek);  // É um enum
            

          
            

        

            Console.ReadLine();
        }
    }
}