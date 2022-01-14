using System;
using System.Collections.Generic;
using aula.pilha;
using aula.fila;

namespace aula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /* int[] initialStack = new int[0];

            PilhaRoots.Menu(initialStack); */

            //Pilha.Menu(new Stack<int>());
            Fila.Menu(new Queue<int>());
        }
    }
}
