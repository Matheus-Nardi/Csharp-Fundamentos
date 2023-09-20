
namespace Variaveis;

class Program
{
    static void Main(string[] args)
    {
        //Constante
        const int Idade_Mínima = 18;
        Console.WriteLine(Idade_Mínima);
        Console.WriteLine("-------------------------------");

        //Tipo byte 
        byte meuByte = 255;
        Console.WriteLine(meuByte);
        Console.WriteLine("-------------------------------");

        //Tipo inteiro
        int idade = 25;  //Oucpa 32bit
        short idadeShort = 22;  //Ocupa 16bit
        long idadeLong = 14; //Ocupa 64bit

        uint A = 12;     // o u na frente não permite numeros negativos
        ushort B = 12;     // o u na frente não permite numeros negativos
        ulong C = 12;     // o u na frente não permite numeros negativos
        Console.WriteLine(A);
        Console.WriteLine("-------------------------------");

        //Tipo Real

        var salario = 22.175;  // Por padrão , utilizando Var , aloca o dado como um double

        float media = 6.5f;    // Float necessita do F 
        decimal valorBanana = 7.34m;  //Decimal necessita do M
        double valorBruto = 55.741;  // Não necessita  de nenhum "cast" 
        Console.WriteLine(media);
        Console.WriteLine(valorBanana);
        Console.WriteLine(valorBruto);
        Console.WriteLine(salario);
        Console.WriteLine("-------------------------------");


        // Tipo caractere  
        char escolhaUsuario = 'a';
        var opcao = 'x';
        Console.WriteLine(escolhaUsuario);
        Console.WriteLine("-------------------------------");

        //Tipo bool

        var Pix = true;  //Armazena um tipo booleano , sendo true or false 
        bool CPF = false;
        bool senhaExistente = false;
        Console.WriteLine(Pix);
        Console.WriteLine("-------------------------------");

        //Tipo string

        string name = "Matheus Alexandre";
        var cadeia = "Uma cadeia de  caracteres";
        Console.WriteLine(cadeia , name);
        Console.WriteLine("-------------------------------");


        // Tipo object ( o mais génerico)

        object nome;
        nome = "Pedro";  // Assume varios valores , pode declarar vazio também
        nome = 2;
        nome = true; 

        Console.WriteLine(nome);

        Console.WriteLine("---------------------------------------");

        

        Console.ReadKey();
        
    }
}
