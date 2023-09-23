namespace StartsWith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var texto = "Bololo Haha";
            Console.WriteLine(texto);
            if (texto.StartsWith("Bololo"))
            {
                Console.WriteLine("Tá tranquilo tá favoravel ");
            }
            else
            {
                Console.WriteLine("Nada tranquilo");
            }


            var frase = "Caboco , tu gosta de farinha ?";
            Console.WriteLine(frase);
            if (frase.EndsWith("?" ))
            {
                Console.WriteLine("E de peixe ? ");
                Console.WriteLine("TU É DOIIIIDOOOO");
            }
            else
            {
                Console.WriteLine("0 memes hoje ");
            }


          

            Console.ReadLine();
        }
    }
}