namespace Funçoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeuNome(); // Tipo 1 
            MeuNome("Pedro"); //Tipo 2 
            var nome = MeuNomeRetorno(); // Tipo 3 
            Console.WriteLine("------------");
            Console.WriteLine(nome);

            var nome1 = MeuNomeRetorno("Pedro");
            Console.WriteLine("------------");
            Console.WriteLine(nome1);

            PegaInfo(17, "Xaves ", "Alemão ");

            var parametro = ParametroNaoObrigatorio("M" , 78.5);
            Console.WriteLine(parametro);


            Console.ReadKey();





        }


        static void MeuNome()  //Sem parametro e sem retorno 
        {
            Console.WriteLine("Meu nome é Matheus");
            Console.WriteLine("------------------");
        }

        static void MeuNome(string nome)  // Com paramentro e sem retorno 
        {
                Console.WriteLine($"Nome: {nome}");
                Console.WriteLine("-------------------");
        }

        static string MeuNomeRetorno()   // Sem parametro e com retorno , preciso atribuir a uma varíavel
        {
            
            return "Meu nome é Matheus";
          
        }

        static string MeuNomeRetorno(string nome)  //Com parametro e com retorno 
        {
            
            return nome; 
        }


        static void PegaInfo(int idade , string apelido , string nacioalidade ) //Ex com mais de um parametro 
        {
            Console.WriteLine($" Idade : {idade} \n Apelido : {apelido} \n Nacionalidade {nacioalidade}");
        }

        static string ParametroNaoObrigatorio(string sexo , double peso = 0 ) // Parametro não obrigatório
        {
             return sexo + " " + peso;
        }
      
    }

}