namespace InicializarArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[2] { 23 ,45 };
            Console.WriteLine(num[0]);
            Console.WriteLine(num[1]);

            var countVogais = 0;
            char[] vogais = new char[5]
            {
                'a' , 'e' , 'i' ,'o' ,'u'
            };

            var nome = "Matheus";

            for(int i = 0; i < nome.Length  ; i++)
            {
                if (vogais.Contains(nome[i]))
                {
                    countVogais++;
                }
            }

            Console.WriteLine("Seu nome possuiu vogais {0}" , countVogais);

            Console.ReadLine();

        }
    }
}