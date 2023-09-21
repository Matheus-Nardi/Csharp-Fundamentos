using System.Globalization;
using System.IO;
using System.Text;

namespace TextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
              Menu();
        }


        static void Menu()
        {
            Console.WriteLine("O que voce deseja fazer ? ");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("3 - Ober dados de um arquivo");
            Console.WriteLine("4 - Criar Diretório");
            Console.WriteLine("5 - Obter dados de um diretorio");
            Console.WriteLine("6 - Ajuda");
            Console.WriteLine("0 - Sair");

            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                case 6: Ajuda(); break;
                case 3: InfoArqivo(); break;
                case 4: CriarDiretorio(); break;
                case 5: InfoDiretorio(); break;
                default: Console.WriteLine("Nenhuma opção reconhecida ! "); Menu(); break;
            }
        }
        static void Ajuda()
        {
            Console.Clear();
            Console.WriteLine("----------------------------");
            Console.WriteLine("Para abrir um arquivo , voce deve inserir o caminho de arbetura");
            Console.WriteLine("Pode fazer isso clicando com o segundo botão no arquivo e selecionar a opção Copiar como caminho ");
            Console.WriteLine("Lembre-se de retirar as aspas ");
            Console.WriteLine(@"Exemplo : \C:\\Users\\55639\\Área de Trabalho\\Atalhos VsCodE.txt\");
            Console.WriteLine("E para salvar o arquivo , insira o seu caminho  e adicone o nome/tipo que será salvo");
            Console.WriteLine(@"Exemplo : caminho\nome do arquivo.txt");
            Console.WriteLine("-----------------------------");

            Console.ReadLine();
            Menu();
        }
        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo para leitura ? ");
            var path = Console.ReadLine();


            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                StreamReader leitor = new StreamReader(stream, Encoding.UTF8);
                Console.WriteLine("-------------------");
                string line;
                while ((line = leitor.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine(line);
                Console.WriteLine("-------------------");
            }



            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }
        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC PARA SAIR )");
            Console.WriteLine("----------------------------------------");

            string texto = "";
            do
            {
                texto += Console.ReadLine(); // Recebe o que ja foi escrito mais o que será digitado 
                texto += Environment.NewLine; // Garante a quebra de linha 
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape); //Verificando se a tecla digita pelo usuario foi o enter 

            Salvar(texto);
            Console.ReadLine();


        }
        static void InfoArqivo()
        {
            Console.Clear();
            Console.WriteLine("Digite o caminho do arquivo :");
            var path = Console.ReadLine();

            FileInfo file = new FileInfo(path);
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Nome do arquivo: {file.Name}");
            Console.WriteLine($"Caminho do arquivo: {file.FullName}");
            Console.WriteLine($"Extensão do arquivo: {file.Extension}");
            Console.WriteLine($"Existencia do arquivo {file.Exists}");
            Console.WriteLine($"Data de criação do arquivo : {file.CreationTime}");
            Console.WriteLine("Tamanho arquivo : {0} KB", file.Length);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }
        static void CriarDiretorio()
        {
            Console.Clear();
            Console.WriteLine("O diretorio será criado na pasta desse projeto TextEditor > bin > Debug > net6.0 ");
            Console.WriteLine("Digite o nome do seu diretorio a ser criado : ");
            var nomeDiretorio = Console.ReadLine();

            if(Directory.Exists(nomeDiretorio) == true ) 
            {
                Console.WriteLine("Pasta ja existente");
                Console.WriteLine("Deseja excluir o diretorio sim|nao (CUIDADO COM AS ESCOLHAS !) ");
                string escolha = Console.ReadLine().ToLower();

                switch (escolha)
                {
                    case "sim": Directory.Delete(nomeDiretorio); break;
                    case "nao":
                        Console.WriteLine("Pasta mantida");
                        break;
                    default: Console.WriteLine("Nenhuma opção reconhecida "); CriarDiretorio(); break;
                }

            }
            else
            {
                
                Directory.CreateDirectory(nomeDiretorio);
                Console.WriteLine("Criando um novo diretorio");
                Thread.Sleep(2100);
                Console.WriteLine("Pasta criada :) ");
                Console.ReadLine();
            }
          
            Menu();
        }
        static void InfoDiretorio()
        {
            Console.Clear();
            Console.WriteLine("Digite o caminho do diretorio : ");
            var path = Console.ReadLine();

            DirectoryInfo infoDiretorio = new DirectoryInfo (path);

            foreach(var pasta in infoDiretorio.GetDirectories())
            {
                foreach(var arquivo in pasta.GetFiles())
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine($"Nome do arquivo: {arquivo.Name}");
                    Console.WriteLine($"Caminho do arquivo: {arquivo.FullName}");
                    Console.WriteLine($"Extensão do arquivo: {arquivo.Extension}");
                    Console.WriteLine($"Existencia do arquivo {arquivo.Exists}");
                    Console.WriteLine($"Data de criação do arquivo : {arquivo.CreationTime}");
                    Console.WriteLine("Tamanho arquivo : {0} KB", arquivo.Length);
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Menu();
                }
            
            }
        }
        static void Salvar(string texto)
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho para salvar o arquivo ? ");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))  //Uso using para fechar  e abrir o arqivo 
            {
                file.Write(texto);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso ! ");
            Console.ReadLine();
            Menu();
        }
    }
}