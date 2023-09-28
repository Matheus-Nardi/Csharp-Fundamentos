using System.Text;
namespace StringBuilde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var texto = new StringBuilder();
            texto.Append("Juntando ");
            texto.Append("varios textos ");
            texto.Append("usando ");
            texto.Append("apenas o stringbuilder ");
            texto.Append("aulas cria ");


            texto.ToString();
            Console.WriteLine(texto);
           

            Console.ReadLine();
        }
    }
}