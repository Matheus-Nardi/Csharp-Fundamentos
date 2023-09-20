namespace LaçosDeRepetição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0;i <=5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------------");

            int cont = 0;
            while(cont<=5)
            {
                Console.WriteLine(cont);
                cont++;
            }

            Console.WriteLine("---------------");

            int inteiro = 0;
            do
            {
                Console.WriteLine(inteiro);
                inteiro++;
            } while (inteiro <= 5);



            Console.ReadKey();
        }


    }
}