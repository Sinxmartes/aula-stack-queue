using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace aula.examples
{
    public class paralelismo {
        public static void Processo() {
            Console.WriteLine("Sincrono");
            for(int i=0; i < 100; i++) {
                Console.WriteLine($"{i} Thread: {Thread.CurrentThread.ManagedThreadId}");
                //Thread.Sleep(500);
            }
            Console.Write("\n");
            List<string> marcas = new List<string>();
            marcas.Add("Asus");
            marcas.Add("Asrock");
            marcas.Add("Gigabyte");
            marcas.Add("Seagate");
            marcas.Add("Samsung");
            marcas.Add("Corsair");
            marcas.Add("NZXT");
            marcas.Add("Cooler Master");
            marcas.Add("Kingston");
            foreach(string marca in marcas) {
                Console.WriteLine($"{marca} Thread: {Thread.CurrentThread.ManagedThreadId}");
            }
        }

        public static void Paralelo() {
            Console.WriteLine("Paralelo");
            Parallel.For(0, 100, i => Console.WriteLine($"{i} Thread: {Thread.CurrentThread.ManagedThreadId}"));
            Console.Write("\n");
            List<string> marcas = new List<string>();
            marcas.Add("Asus");
            marcas.Add("Asrock");
            marcas.Add("Gigabyte");
            marcas.Add("Seagate");
            marcas.Add("Samsung");
            marcas.Add("Corsair");
            marcas.Add("NZXT");
            marcas.Add("Cooler Master");
            marcas.Add("Kingston");
            Parallel.ForEach(marcas, marca => Console.WriteLine($"{marca} Thread: {Thread.CurrentThread.ManagedThreadId}"));
        }
    }
}