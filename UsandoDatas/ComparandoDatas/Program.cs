namespace ComparandoDatas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ano, mes, dia = 0;
            Console.WriteLine("Digite a data de nascimento dd/mm/yyyy");
            dia = int.Parse(Console.ReadLine());
            mes = int.Parse(Console.ReadLine());
            ano = int.Parse(Console.ReadLine());

            var dataDeNascimento = new DateTime(ano , mes , dia);

            if(DateTime.Now.Year - dataDeNascimento.Year < 18)
            {
                Console.WriteLine("MUITO NOVINHO");
            }
            else
            {
                Console.WriteLine("MADURO");
            }

            Console.Read();
        }
    }
}