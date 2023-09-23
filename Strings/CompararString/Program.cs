namespace CompararString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var texto = "Ola";

            //Compare To Se realmente é igual
            Console.WriteLine(texto.CompareTo("Ola")); //Retorna um int (0 se for verdadeiro)
            Console.WriteLine(texto.CompareTo("ola")); //Retorna um int (1 se for falso) case sensitve

            //Contains Se contem um parte ou tudo , opcional 
            var frase = "Manoel Gomes é um ídolo nacional";
            Console.WriteLine(frase.Contains("Manoel"));  //Retorna um booleano
            Console.WriteLine(frase.Contains("manoel"));  //Retorna um booleano
            Console.WriteLine(frase.Contains("manoel", StringComparison.OrdinalIgnoreCase)); //ingnorando o case sensitive

            Console.ReadLine();

            Buscar();

        }


        //Lista Telefonica  Exemplo

     
        static void Buscar()
        {
            Console.WriteLine("Quem voce deseja adicionar ? ");

            var nome  = Console.ReadLine();

            Console.WriteLine("Qual o número de contato de {nome} : "  );
            var numContato = Console.ReadLine();

            Console.WriteLine("Buscar por : ");
            var nomeBusca = Console.ReadLine();

            if (nomeBusca.Contains(nome))
            {
                Console.WriteLine("Usuario encontrado");
                Console.WriteLine($"Numero de contato : {numContato}");

            }

            Console.ReadLine();

        }

    }




}