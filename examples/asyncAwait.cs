using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace aula.examples
{
    public class asyncAwait {
        public async Task ResultadoValor() {
            var client = new HttpClient();
            ExecutadoIndependente();
            int qtde = retornaInteiro();
            string contents = await client.GetStringAsync("https://economia.awesomeapi.com.br/last/USD-BRL");
            Moeda moeda = JsonSerializer.Deserialize<Moeda>(contents);
            double valorFinal = Convert.ToDouble(moeda.USDBRL.high.Replace(".", ",")) * qtde;
            Console.WriteLine("O valor convertido em reais é: " + valorFinal);            
        }

        public void ExecutadoIndependente() {
            Console.WriteLine("Eu estou sendo executado independentemente");
        }

        public int retornaInteiro() {
            Random random = new Random();
            int valor = random.Next(0, 100);
            return valor;
        }

        public async Task Executar() {
            await Task.WhenAll(
                Task.Run(() => GetTaskOfTResultAsync()), 
                Task.Run(() => ResultadoValor()), 
                Task.Run(() => showMessages())
            );
        }

        async Task showMessages() {
            Console.WriteLine("Oi, estamos antes do await");
            Task returnedTask = GetTaskAsync();
            Console.WriteLine("Oi, estamos no meio do await");
            await returnedTask;
            Console.WriteLine("Oi, estamos no fim do await");
        }

        async Task GetTaskOfTResultAsync()
        {
            Random random = new Random();
            int hours = random.Next();
            await Task.Delay(10000);
            Console.WriteLine(hours);
        }

        async Task GetTaskAsync()
        {
            await Task.Delay(5000);
        }
    }
}