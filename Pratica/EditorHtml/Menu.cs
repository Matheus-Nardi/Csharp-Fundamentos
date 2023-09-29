using System;

namespace EditorHtml // mesmo namespace 
{ 
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black; //Mudando o fundo do terminal
            Console.ForegroundColor = ConsoleColor.Green; //Mudando a cor da letra

            DrawnScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            Console.ReadLine();
        }

        public static void DrawnScreen()
        {
            FirstLine(25);
            Lines(8, 25);
            FirstLine(25);

        }


        public static void FirstLine(int colunas )
        {
            Console.Write("+");
            for (int i = 0; i <= colunas; i++)
                Console.Write("-");

            Console.Write("+");

            Console.Write("\n");

        }

        public static void Lines(int linhas , int colunas )
        {
            for (int lines = 0; lines <= linhas; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= colunas; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");

            }
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(8, 1);
            Console.WriteLine("EDITOR HTML");
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("Selecione uma opção:");
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(5, 4);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(5, 6);
            Console.Write("Opção:");
            

        }
    }

}
