namespace Index
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto = "Matheus Teteus";
            
            Console.WriteLine(texto.IndexOf("h"));    // Tipo index recebe parametro do mesmo tipo
            Console.WriteLine(texto.LastIndexOf("e")); //Ultimo indice 
            

            Console.ReadLine();                                         // Pega o indice da letra h 
        }
    }
}