using System;
using System.Collections.Concurrent;

namespace ListaAtividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = 0, countNum = 0;
            //do
            //{
            //    Console.WriteLine("Digite um número : ");
            //    num = int.Parse(Console.ReadLine());

            //    countNum++;

            //} while (num > 0);

            //Console.WriteLine("Numeros digitados :{0}", countNum);
            //Console.Read();

            //int num , countPar = 0, countImpar = 0;

            //for(int i = 0; i < 10 ; i++) 
            //{
            //    Console.WriteLine($"Digite o {i +1} numero : ");
            //    num = int.Parse( Console.ReadLine() );

            //    if( num%2 == 0 )
            //    {
            //        countPar++;
            //    }
            //    else
            //    {
            //        countImpar++;
            //    }

            //}
            //Console.WriteLine("NUMEROS PARES {0} ", countPar);
            //Console.WriteLine("NUMEROS IMPARES {0} ", countImpar);

            //int num , numMaior = 0, termos = 0 ;

            //Console.WriteLine("Digite o tamanho da sequencia : ");
            //termos = int.Parse(Console.ReadLine());
            //if(termos < 6)
            //{
            //    Console.WriteLine("PARAMETOS INVÁLIDOS , MIN 6 MÁX 10");

            //}
            //else if (termos >= 10)
            //{
            //    Console.WriteLine("PARAMETOS INVÁLIDOS , MIN 6 MÁX 10");


            //}
            //else
            //{



            //for (int i = 0; i < termos; i++) 
            //{
            //    Console.WriteLine($"Digite o {i+1} numero ");
            //    num = Convert.ToInt32(Console.ReadLine());
            //    numMaior = num;

            //    if(num > numMaior) 
            //    {
            //        numMaior = num;
            //    }


            //}
            //Console.WriteLine("MAIOR NÚMERO DIGITADO : {0}" , numMaior);
            //}

            //string texto = "";
            //int countPara =0 ;

            //while( !(texto.Equals("sair")))
            //{
            //    Console.WriteLine("Digite um frase :");
            //    texto = Console.ReadLine();
            //    if(texto.Equals("para"))
            //    {
            //        countPara++;
            //    }
            //}
            //Console.WriteLine("PARA DIGITADO {0} VEZES " , countPara);

            string senha = "" , confirmaSenha = "";
            int tentativas = 0;

            Console.WriteLine("Digite a sua senha : ");
            senha= Console.ReadLine();
            Console.WriteLine("Confirme sua senha : ");
            confirmaSenha= Console.ReadLine();
            
            while( tentativas <=3)
            {
                Console.WriteLine("Confirme sua senha : ");
                confirmaSenha = Console.ReadLine();
                tentativas++;

            }

            if(confirmaSenha==senha) 
            {
                Console.WriteLine("Senha confirmada");
            }
            else
            {
                Console.WriteLine("Bloqueado");
            }

        }
  
    }
}