using System.Globalization;

namespace InterpolacaoDeString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var preco = 100.89;
            var id = Guid.NewGuid();

            Console.WriteLine("=====================");
            // Concatenação com + 
            string frase = "O preço do seu produto é " + preco ;
            Console.WriteLine(frase);



            Console.WriteLine("=====================");
            //Com formatação de string , eu entendo como place holder 
            string frase1 = string.Format("O preço do seu produto é {0} com id de rastreamento : {1}" , preco , id );
            Console.WriteLine(frase1);


            Console.WriteLine("=====================");
            //Com cifrão  + legivel 
            string frase2 = $"O preço do produto é {preco} e o código de rastreamento é {id}";
            Console.WriteLine(frase2);

            Console.ReadKey();
        }
    }
}