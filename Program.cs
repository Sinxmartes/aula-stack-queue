using System;
using System.Collections.Generic;
using aula.pilha;
using aula.fila;
using aula.lista;
using aula.examples;
using System.Threading;
using System.Threading.Tasks;


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
            //Fila.Menu(new Queue<int>());
            //Menu.main();

            //sort.Iniciar();
            //search.Iniciar();
            
            //Sincrono
            paralelismo.Processo();
            paralelismo.Paralelo();

            //Paralelo - 1
            /* Parallel.Invoke(
                new Action(paralelismo.Processo),
                new Action(paralelismo.Paralelo)
            ); */
            //Paralelo - 2
            /* Parallel.Invoke(
                () => { paralelismo.Processo(); },
                () => { paralelismo.Paralelo(); }
            ); */
        }
    }
}