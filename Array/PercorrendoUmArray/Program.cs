namespace PercorrendoUmArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5]{ 1, 2, 3 , 4 ,5 };

            for(int index = 0 ; index < num.Length; index++) 
            {
                Console.WriteLine(num[index]);
            }

            string[] nomes = new string[3] {"Carlos " , "Matheus" , "Vinicius"};
            //Percorrendo com foreach(para cada)
            foreach(var nome in nomes)
                Console.WriteLine(nome);

            Console.WriteLine("----------------------------");
            var funcionarios = new Funcionario[3];
            funcionarios[0] = new Funcionario() { NomeFuncionario = nomes[0] , idadeFuncionario = 21};
            funcionarios[1] = new Funcionario() { NomeFuncionario = nomes[1] , idadeFuncionario = 24};
            funcionarios[2] = new Funcionario() { NomeFuncionario = nomes[2] , idadeFuncionario = 41};

            foreach(var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.NomeFuncionario);
                Console.WriteLine(funcionario.idadeFuncionario);
            }

            Console.Read();
        }
    }

    public struct Funcionario
    {
        public string NomeFuncionario;
        public int idadeFuncionario;
    }
}