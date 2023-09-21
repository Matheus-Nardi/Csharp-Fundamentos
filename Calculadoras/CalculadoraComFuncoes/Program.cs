namespace CalculadoraComFuncoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Menu();
        }



        static void Menu()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Soma(+)");
            Console.WriteLine("Subtração(-)");
            Console.WriteLine("Mutiplicação(*)");
            Console.WriteLine("Divisão(/)");
            Console.WriteLine("Potenciação(^)");
            Console.WriteLine("Radiciação(R)");
            Console.WriteLine("Ou Menu Programador (P)");
            Console.WriteLine("Sair(Q)");
            Console.WriteLine("---------------------");
            Console.WriteLine("Escolha uma opção : ");

            char op = Convert.ToChar(Console.ReadLine());

            switch (op)

            {

                case '+':
                    Soma();

                    break;
                case '-':
                    Subtracao();
                    break;
                case '*':
                    Mutiplicacao();
                    break;
                case '/':
                    Divisao();
                    break;
                case '^':
                    Potencia();
                    break;
                case 'R': Radiciacao(); break;
                case 'r': Radiciacao(); break;
                case 'p': MenuProgramador(); break;
                case 'P': MenuProgramador(); break;
                case 'Q': Leave(); break;
                case 'q': Leave(); break;

                default: Console.WriteLine("Opcão não reconhecida"); Menu(); break;

            }


        }
        static void MenuProgramador()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma opção :");
            Console.WriteLine("1 - Conversão Decimal-> Binário ");
            Console.WriteLine("2 - Sair ");
            int op = Convert.ToInt32(Console.ReadLine());

            switch(op) 
            {
                case 1:
                    Programador(); 
                    break;
                case 2:
                    Leave();
                    break;
            
            }
        }
        static void Soma()

        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro número : ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número : ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;

            Console.WriteLine("-------------------");
            Console.WriteLine($"A soma entre {v1} + {v2} = {resultado}");

            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro número : ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número : ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;

            Console.WriteLine("-------------------");
            Console.WriteLine($"A subtração entre {v1} - {v2} = {resultado}");

            Menu();
        }
        static void Mutiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro número : ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número : ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;

            Console.WriteLine("-------------------");
            Console.WriteLine($"A mutiplicação entre {v1} * {v2} = {resultado}");

            Menu();
        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro número : ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número : ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;

            Console.WriteLine("-------------------");
            Console.WriteLine($"A divisao entre{v1} / {v2} = {resultado}");

            Menu();
        }
        static void Potencia()
        {

            Console.Clear();
            Console.WriteLine("Numéro que será a base : ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Numéro que será o exponete : ");
            float v2 = float.Parse(Console.ReadLine());

            double resultado = Math.Pow(v1, v2);
            Console.WriteLine($"A base {v1} ^ {v2} = {resultado} ");

            Menu();
        }
        static void Radiciacao()
        {
            Console.WriteLine("Digite o numero para obter sua raiz Quadrada : ");
            float v1 = float.Parse(Console.ReadLine());

            float resultado = (float)Math.Sqrt(v1);
            Console.WriteLine($"A raiz quadrada de {v1} = {resultado} ");

            Menu();
        }
        static void Leave()
        {
            Console.WriteLine("Obrigado por usar nossa calculadora ! :)");
            Console.ReadKey();
            System.Environment.Exit(0);
        }
        static void Programador()
        {
            Console.Clear();
            Console.WriteLine("Digite um número na base decimal para transforma-lo em bínario");
            int v1 = int.Parse(Console.ReadLine());

            int num = v1;
           
            string binary = "";

            while(v1>0) 
            {
              int remainder = v1 % 2;
              binary = remainder + binary;
              v1 /= 2;
            }

            
            Console.WriteLine($"O número {num} na base binária é = {binary} ");
            Console.ReadKey();
            Console.WriteLine("Continuar no modo programador ? S|N");
            char op = Convert.ToChar(Console.ReadLine().ToUpper());
            switch (op) 
            {
               case 'S': MenuProgramador(); break;
               case 'N': Menu(); break;
            }
        }
        
        
    }
}
    
  




