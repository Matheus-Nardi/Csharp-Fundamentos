namespace StringsAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid(); // Criando um novo Identificador global 
            

            id = new Guid("8a6c5e5b-571e-40db-83fc-06a9074d6d19"); // Passando um id com formatacao válida
            Console.WriteLine(id.ToString().Substring(0,8));// Pegando só os 8 primeiros dígitos

            

            Console.ReadKey();
        }
    }
}