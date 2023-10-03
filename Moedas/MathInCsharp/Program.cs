namespace MathInCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal numero = 455.43m;
            
            //Arredonda para um num maior
            Console.WriteLine(Math.Ceiling(numero));
           

            //Arredonda para um num menor
            Console.WriteLine(Math.Floor(numero));

            //Arredonda "tirando" as casas decimais 
            Console.WriteLine(Math.Round(numero));


            //Existem inumeras funções 

            Console.WriteLine(Math.Pow(10.0 , 2.0));
            Console.WriteLine(Math.Sqrt(64));
            Console.WriteLine(Math.Abs(-78.9));


            Console.ReadLine(); 
        }
    }
}