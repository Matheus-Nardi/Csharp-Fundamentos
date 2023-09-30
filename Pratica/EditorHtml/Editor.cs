using System;
using System.Text;
using System.IO;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Modo Editor");
            Console.WriteLine("------------");
            Console.WriteLine("ESC PARA SAIR");
            Console.WriteLine("DIGITE SEU TEXTO :");
            Start();

        }

        public static void Start()
        {
            var texto = new StringBuilder();


            do
            {
                texto.Append(Console.ReadLine());
                texto.Append("\n");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("------------");


            Console.WriteLine("Deseja salvar o arquivo |1 -Sim|2-Nao|3-Apenas vizualizar");
            short escolha = short.Parse(Console.ReadLine());
         
            switch (escolha)
            {
                case 1: Save(texto); break;
                case 2: Menu.Show(); break;
                case 3: View.Show(texto.ToString()); break;
            }



        }

        public static void Save(StringBuilder texto)
        {
            Console.Clear();
            Console.WriteLine("Qual o path para salvar o arquivo?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(texto);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso !");
            Console.WriteLine("Pressione qualquer tecla para continuar :)");
            Console.ReadLine();
            Menu.Show();

        }
    }
}
    
