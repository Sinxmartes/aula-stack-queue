using System;
using System.Collections.Generic;

namespace aula.examples
{
    public class search
    {
        static int[] elementos = new int[10];

        public static void Iniciar() {
            Console.ReadLine();
            
            Console.WriteLine("Busca...");

            Console.WriteLine("Escolha uma das opções...");
            Console.WriteLine("1. Linear Search...");
            Console.WriteLine("2. Binary Search...");
            Console.WriteLine("0. Sair");
            Console.Write("Opção: ");

            switch (Console.Read())
            {
                case '1':
                    Console.ReadLine();
                    for(int i=0;i < elementos.Length; i++) {
                        Console.WriteLine("Insira o numero da posição {0} ...", i);
                        elementos[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("Insira o valor de deseja buscar...");
                    linearSearch(Convert.ToInt32(Console.ReadLine()));
                    break;
                case '2':
                    Console.ReadLine();
                    for(int i=0;i < elementos.Length; i++) {
                        Console.WriteLine("Insira o numero da posição {0} ...", i);
                        elementos[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("Insira o valor de deseja buscar...");
                    binarySearch(Convert.ToInt32(Console.ReadLine()));                    
                    break;
                case '0':
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção invalida, tente novamente...");
                    break;
            }
            Iniciar();
        }

        private static void linearSearch(int numero) {
            for (int i = 0; i < elementos.Length; i++)
            {
                if (elementos[i] == numero)
                {
                    Console.WriteLine("Busca feita com sucesso " + "O número " + elementos[i] + " foi encontrado no índice " + i);
                    break;
                }
                else
                {
                    Console.WriteLine("Busca falhou...");
                }
            }
        }

        private static void binarySearch(int numero) {
            int baixo = 0;
            int alto = elementos.Length - 1;

            while (baixo <= alto)
            {
                int medio = (baixo + alto) / 2;

                if (numero < elementos[medio])
                {
                    alto = medio - 1;
                }
                else if (numero > elementos[medio])
                {
                    baixo = medio + 1;
                }
                else if (numero == elementos[medio])
                {
                    Console.WriteLine("Busca feita com sucesso " + "O número " + numero + " foi encontrado no índice " + medio);
                    break;
                }
            }
        }
    }
}