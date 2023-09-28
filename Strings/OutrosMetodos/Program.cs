using System.Globalization;

namespace OutrosMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Maria Barros ";
            //Minusculo Maisculo
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.ToUpper());

            //Inserir Remover
            Console.WriteLine(name.Insert(6, "Eduarda"));
            Console.WriteLine(name.Remove(1,1));
            Console.WriteLine(name.Length);
            

            //Sbstituir 
            var apelido = "Casca de Bala";
            apelido = apelido.Replace("a" , "e");
            apelido = apelido.Replace("c" , "S");
            apelido = apelido.Replace("l" , "4");
            apelido = apelido.Replace("s ", "!");
            Console.WriteLine(apelido);

            //Dividir a string 
            var divisao = name.Split(" "); // Dividir pela quantidade de espacos . Retorna um array
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
           
            // Pegar a strig passando indices
            var novoNome = name.Substring(0, name.LastIndexOf("i"));
            var novoApelido = apelido.Substring(0, 5);
            Console.WriteLine(novoApelido);
            Console.WriteLine(novoNome);

            //Remove espacos do inicio e final 
            Console.WriteLine(name.Trim());

            Console.Read();

        }
    }
}