using System;

namespace ArrayComStruct
{
    public class Program
    {
        public static void Main()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Aluno[] alunos = null; // Declare o array de alunos aqui

            while (true) // Crie um loop infinito para exibir o menu continuamente
            {
                Menu();
              
                short op = short.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        System.Environment.Exit(0);
                        break;
                    case 1:
                        Console.WriteLine("Quantos alunos a serem adicionados? ");
                        int quantidade = int.Parse(Console.ReadLine());
                        alunos = new Aluno[quantidade];
                        AddAlunos(alunos);
                        break;
                    case 2:
                        if (alunos != null)
                        {
                            VizuAlunos(alunos);
                        }
                        else
                        {
                            Console.WriteLine("Nenhum aluno foi adicionado ainda.");
                        }
                        break;
                }
            }
        }

        public static void Menu()
        {
           
            Console.WriteLine("1-Add info aluno");
            Console.WriteLine("2-Visualizar alunos");
            Console.WriteLine("3-Calcular Média");
            Console.WriteLine("0-Sair");
            Console.WriteLine("Escolha uma opção:");
        }

        public static void AddAlunos(Aluno[] alunos)
        {
            for (int i = 0; i < alunos.Length; i++)
            {
                Console.WriteLine($"Digite o nome do {i + 1}° Aluno:");
                alunos[i].Nome = Console.ReadLine();

                Console.WriteLine($"Digite a idade do {i + 1}° Aluno:");
                alunos[i].Idade = int.Parse(Console.ReadLine());

                Console.WriteLine($"Digite a nota do {i + 1}° Aluno:");
                alunos[i].Nota = double.Parse(Console.ReadLine());

                Console.WriteLine("------------------");
                Console.Clear();
            }
        }

        public static void VizuAlunos(Aluno[] alunos)
        {
            foreach (var aluno in alunos)
            {
                Console.WriteLine("Nome: " + aluno.Nome);
                Console.WriteLine("Idade: " + aluno.Idade);
                Console.WriteLine("Nota: " + aluno.Nota);
                Console.WriteLine();
            }
        }
      

      

        public struct Aluno
        {
            public string Nome;
            public int Idade;
            public double Nota;
        }

    }
}
