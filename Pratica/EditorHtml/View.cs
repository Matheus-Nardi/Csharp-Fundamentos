using System;
using System.Text.RegularExpressions;

namespace EditorHtml
{
    public class View
    {
         public static void Show(string text)
         { 
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Modo Viewer");
            Console.WriteLine("------------");
            Replace(text);
            Console.WriteLine("------------");
            Console.ReadKey();
            Menu.Show();


         }

        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var matches = strong.Matches(text);
            var startIndex = 0;

            foreach (Match match in matches)
            {
                // Imprima o texto antes da tag <strong> em preto
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(text.Substring(startIndex, match.Index - startIndex));

                // Imprima o texto dentro da tag <strong> em azul
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(match.Groups[1].Value);

                startIndex = match.Index + match.Length;
            }

            // Imprima o texto restante após a última tag </strong> em preto
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(text.Substring(startIndex));

            Console.ResetColor(); // Restaura a cor original do console
        }



    }
}