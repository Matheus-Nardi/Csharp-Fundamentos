namespace Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Eduardo";
            if (nome == "Pedro")
                Console.WriteLine("Encontrei Pedro");
            else if (nome == "Carlos")
                Console.WriteLine("Encontrei Carlos");
            else if (nome == "Matheus")
                Console.WriteLine("Ecnontrei Matheus");
            else Console.WriteLine("Achei foi nada ");

            Console.WriteLine("----------------------------------");

            string nomeUsuario = "Pedrin0800";      //Uso switch quando tiver muitas opçoes / caso
            switch (nomeUsuario)
            {
                case "HotDogRaivoso":
                    Console.WriteLine("Achei HotDogRaivoso");
                    break;
                case "Pedrin0800":
                    Console.WriteLine("Opa , é o pedrin");
                    break;
                default: Console.WriteLine("Achei nada "); break;
            }



            Console.ReadKey ();
        }
    }
}