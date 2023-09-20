namespace Structs_Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var produto = new Product(1 , "Faca Tramontina" , 85.90 , EProductType.Produto); // Inicializando pelo construtor 
            var produto2 = new Product();
            produto2.Id = 22;                    // Declarando "manualmente" com o nomeDoStruct.propriedade/método
            produto2.Name = "Saco de Cimento";
            produto2.Price = 50;
            Console.WriteLine(produto2.Id);
            Console.WriteLine(produto2.Name);
            Console.WriteLine(produto2.Price);

            Console.WriteLine("-------------");
            Console.WriteLine(produto.Id);
            Console.WriteLine(produto.Name);
            Console.WriteLine(produto.Price);
            Console.WriteLine(produto.PriceInDolar(4.86));
            Console.WriteLine(produto.Type); //Imprimo a escrita do tipo 
            Console.WriteLine((int)produto.Type);//Imprimo o valor literal


            Console.ReadKey();
        }


        struct Product 
        {

            public Product(int id , string name , double price , EProductType type)  // Construtor que logo ao declarar se passado os parametros ira inicializar
            {
                Id = id ;
                Name = name;
                Price = price ;
                Type = type ;
            }
            public int Id;      // Propriedades
            public string Name;
            public double Price;
            public EProductType Type;  //Declarando o meu enum (ele torna-se um tipo) 

            public double PriceInDolar(double dolar)   //Metodos /Funções 
            {
                return Price / dolar;
            
            }

        }


        enum EProductType  //Criação do enum , boa prática começar com E
        {
            Produto = 1 ,  
            Servico = 2 
        }
    }
}