namespace JogoDeAdvinhar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pagina do Usuario 1
            int vezes = 0;
            string palavra = "", tema = " ";
            Console.WriteLine("Digite uma palavra : ");
            palavra = Console.ReadLine();
            palavra.ToLower();
            Console.WriteLine("Digite o tema : ");
            tema = Console.ReadLine();

            Console.Clear();

            //Usuario que irá advinhar 
            Console.WriteLine("Vamos começar ");
            Console.WriteLine($"Tema : {tema}");
            Console.WriteLine($"Quantida de letras : {palavra.Length}");

            while (vezes < 3)
            {

                Console.WriteLine("Chute uma letra ");
                char chute = ' ';
                chute = char.Parse(Console.ReadLine());
                char.ToLower(chute);

                //Verificando a existencia do chute 
                if (!palavra.Contains(chute))
                {
                    Console.WriteLine($"Não possui a letra {chute}");
                    vezes++;
                    Console.WriteLine("TENTATIVAS : {0} | MAXIMO 3", vezes);
                }
                else
                {

                    //Percorrendo cada caractere da palavra 
                    for (int i = 0; i < palavra.Length; i++)
                    {

                        if (palavra[i].Equals(chute))
                        {
                            Console.Write($"{chute}");
                        }
                        else
                        {
                            Console.Write("_");
                        }

                    }
                    Console.WriteLine("");
                    Console.WriteLine("Ja sabe a resposta ? Y(TENTAR) N(AINDA NAO SEI)");
                    char op = char.Parse(Console.ReadLine());

                    if (op == 'Y' || op == 'y')
                    {

                        string tentativa = "";
                        Console.Write("TENTATIVA :");
                        tentativa = Console.ReadLine();

                        if (tentativa.Equals(palavra))
                        {
                            Console.WriteLine("VOCE ACERTOU !");
                            vezes = 3;
                        }
                        else
                        {
                            Console.WriteLine("AZAR , NÃO É ESSA A PALAVRA");
                            vezes++;
                            Console.Write("TENTATIVAS : {0} | MAXIMO 3", vezes);


                        }

                    }
                    else
                    {
                        Console.WriteLine("OK , CONTINUE TENTANTO");
                    }

                }
            }
            //Proximo objetivo : Adiconar uma "mémoria ao programa para que os outros inputs não sejam perdidos"
            Console.ReadKey();
        }
    }
}