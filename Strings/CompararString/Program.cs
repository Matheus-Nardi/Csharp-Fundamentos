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
        }
    }
}