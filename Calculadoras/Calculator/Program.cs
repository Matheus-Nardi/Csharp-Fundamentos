using System.Runtime.Intrinsics;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool repetir = true;
            float resultado = 0;
            Console.WriteLine("Calculadora ");
            Console.WriteLine("-------------");
            Console.WriteLine("Para sair pressione X ");
            Console.WriteLine("Se não , pressione qualquer tecla");
            string opcaoSair = Console.ReadLine();
            if (opcaoSair == "x" || opcaoSair == "X")
                repetir = false;

            while (repetir == true)
            {

                Console.WriteLine("Digite o primeiro valor : ");
                float v1 = float.Parse(Console.ReadLine());
                resultado = v1;

                Console.WriteLine("Digite o segundo valor :  ");
                float v2 = float.Parse(Console.ReadLine());


                Console.WriteLine("Escolha uma das operações | + | - | * | / | X(SAIR|");
                char escolha = Convert.ToChar(Console.ReadLine());

                switch (escolha)
                {
                    case '+': resultado = Soma(v1, v2); Console.WriteLine(resultado); break;
                    case '-': resultado = Subtracao(v1, v2); Console.WriteLine(resultado); ; break;
                    case '*': resultado = Mutiplicacao(v1, v2); Console.WriteLine(resultado); break;
                    case '/': resultado = Divisao(v1, v2); Console.WriteLine(resultado); break;
                    case 'x': repetir = false; break;
                    case 'X': repetir = false; break;
                    default:
                        Console.WriteLine("Opcão não reconhecida");
                        break;

                }

            }
        }



        static float Soma(float n1, float n2)
        {
            return n1 + n2;
        }

        static float Subtracao(float n1, float n2)
        {
            return n1 - n2;
        }

        static float Mutiplicacao(float n1, float n2)
        {
            return n1 * n2;
        }

        static float Divisao(float n1, float n2)
        {
            return n1 / n2;
        }
    }
}