namespace Datas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var data = new DateTime();  //DateTime é um struct  e possui parametros 
            var data = DateTime.Now;  // Pega a data atual 

            Console.WriteLine(data);

            Console.ReadLine();
        }
    }
}