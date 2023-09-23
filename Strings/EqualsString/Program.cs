namespace EqualsString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var texto = "GOL BOLINHA 1994";
            if(texto.Equals("gol" , StringComparison.OrdinalIgnoreCase));
                Console.WriteLine("Gol bolinha do ano de 1994");

            Console.ReadLine();
        }
    }
}