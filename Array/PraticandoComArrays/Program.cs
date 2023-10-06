using System;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Xml.Serialization;

namespace PraticandoComArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Basta chamar o exercicio
            Exercicio7();
            Console.ReadKey();
        }

        public static void Exercicio1()
        {
            //1 - Crie um programa que solicita ao usuário que insira 5 números inteiros e,
            //em seguida, calcule e exiba a soma desses números.

            int[] valores = new int[5];
            int somaValores = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine($"Digite o {i + 1} numero :");
                valores[i] = int.Parse(Console.ReadLine());
                somaValores = valores[i] + somaValores;

            }
            Console.WriteLine($"A soma é :{somaValores}");
        }

        public static void Exercicio2()
        {
            //2-Média de Valores: Peça ao usuário que insira 10 números inteiros e,
            //em seguida, calcule e exiba a média desses números.

            double[] nums = new double[10];
            double media = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"Digite o {i + 1} numero : ");
                nums[i] = double.Parse(Console.ReadLine());
                media = media + nums[i];
            }
            Console.WriteLine($"A media é : {media / nums.Length}");
        }

        public static void Exercicio3()
        {
            //3-Encontre o Maior e o Menor: Solicite ao usuário que insira 10 números inteiros e,
            //em seguida, encontre e exiba o maior e o menor número entre eles.

            var numeros = new int[10];
            var maior = 0;
            var menor = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Digite um número :");
                numeros[i] = int.Parse(Console.ReadLine());

                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }

            }
            Console.WriteLine($"MAIOR NÚMERO : {maior} \nMENOR NÚMERO : {menor}");


        }

        public static void Exercicio4()
        {
            //Pecaça ao usuário que insira 10 números inteiros e, em seguida,
            //conte e exiba quantos deles são pares e quantos são ímpares.

            var numeros = new int[10];
            int countPar = 0, countImpar = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Digite um numero:");
                numeros[i] = int.Parse(Console.ReadLine());

                if (numeros[i] % 2 == 0)
                {
                    countPar++;
                    Console.WriteLine("PAR");
                }
                else
                {
                    countImpar++;
                    Console.WriteLine("IMPAR");
                }
            }

            Console.WriteLine($"Numeros pares:{countPar} \nNumeros impares:{countImpar}");
        }

        public static void Exercicio5()
        {
            //Inversão de Array: Crie um programa que inverta a ordem dos elementos em um array de inteiros.
            //Por exemplo, se o array for [1, 2, 3, 4, 5], o programa deve produzir[5, 4, 3, 2, 1].

            int[] arr = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Original");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("------------------");
            Array.Reverse(arr);
            Console.WriteLine("Invertido");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }

        public static void Exercicio6()
        {
            //Ordenação de Array: Solicite ao usuário que insira 5 números inteiros e,
            //em seguida, ordene esses números em ordem crescente e exiba o array ordenado.

            //Irei colocar nomes

            string[] nomes = new string[5];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Digite o {i + 1} nome :");
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine("DESORDENADO");
            Console.WriteLine("--------------");
            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine("--------------");
            Array.Sort(nomes);
            Console.WriteLine("ORDENADO");
            Console.WriteLine("--------------");
            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine("--------------");

        }


        public static int Exercicio7()
        {
            int[] numeros = new int[5] {1, 8 , 3 , 12 , 24 };
            Console.WriteLine("Buscar número : ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0;i < numeros.Length;i++) 
            {
                if (numeros[i] == num )
                {
                    return i;
                }
                
                
            
            }
           return -1;
        }


    }
}