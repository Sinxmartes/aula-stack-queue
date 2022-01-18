using System;
using System.Linq;

namespace aula.lista
{
    /**
        Criar um menu com as opções
            1 - Adicionar um novo vagão
            2 - Exibir o último vagão
            3 - Exibir todos os vagões
            4 - Buscar por id dentro do trem
            5 - Buscar por nome dentro do trem
            6 - Buscar por peso dentro do trem
            7 - Atualizar as informações de um vagão
            8 - Excluir um vagão
            0 - Sair
    **/

    public class Menu
    {
        public static void main() {

            var listaLigada = new ListaLigada();

            Console.ReadLine();
            Console.WriteLine("Escolha uma das opções...");
            Console.WriteLine("1. Adicionar um novo vagão");
            Console.WriteLine("2. Exibir o último vagão");
            Console.WriteLine("3. Exibir todos os vagões");
            Console.WriteLine("4. Buscar por id dentro do trem");
            Console.WriteLine("5. Buscar por nome dentro do trem");
            Console.WriteLine("6. Buscar por peso dentro do trem");
            Console.WriteLine("0. Sair");
            Console.Write("Opção: ");
            switch (Console.Read())
            {
                case '1':

                    var novoVagao = new Vagao();

                    Console.WriteLine("Adicionando um novo vagão");

                    Console.WriteLine("Insira o Id do vagão");

                    novoVagao.Id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Insira o nome da Carga");

                    novoVagao.Carga = Console.ReadLine();

                    Console.WriteLine("Insira o peso da Carga");

                    novoVagao.Peso = Convert.ToInt32(Console.ReadLine());

                    listaLigada.InserirVagao(novoVagao);

                    break;
                case '2':

                    var ultimoVagao = listaLigada.getUltimoVagao();

                    Console.WriteLine("Último vagão");
                    Console.WriteLine($"Carga: { ultimoVagao.Carga }");
                    Console.WriteLine($"Peso: { ultimoVagao.Peso }");
                    break;
                case '3':

                    foreach (Vagao item in listaLigada.getVagoes())
                    {
                        Console.WriteLine("ID {0}", item.Id);
                        Console.WriteLine("Carga {0}", item.Carga);
                        Console.WriteLine("Peso {0}", item.Peso);
                    }
                    break;
                case '4':

                    Console.WriteLine("Insira o Id do vagão");

                    var id = Convert.ToInt32(Console.ReadLine());

                    var vagao = listaLigada.getVagaoById(id);

                    if (vagao is null)
                    {
                        Console.WriteLine("Não foi encontrado vagão com esse id");
                        break;
                    }

                    Console.WriteLine("ID {0}", vagao.Id);
                    Console.WriteLine("Carga {0}", vagao.Carga);
                    Console.WriteLine("Peso {0}", vagao.Peso);

                    break;
                case '5':

                    Console.WriteLine("Insira o nome da carga");

                    var name = Console.ReadLine();

                    var listaVagoes = listaLigada.getVagoesByName(name);

                    if (listaVagoes.Any())
                    {
                        Console.WriteLine("Não foram encontrados nenhum vagão com essa carga");
                        break;
                    }

                    Console.WriteLine("Foram encontrados {0} vagões", listaVagoes.Count);

                    foreach (var item in listaVagoes)
                    {
                        Console.WriteLine("ID {0}", item.Id);
                        Console.WriteLine("Carga {0}", item.Carga);
                        Console.WriteLine("Peso {0}", item.Peso);
                    }

                    break;
                case '0':
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção invalida, tente novamente...");
                    break;
            }

            //ListaLigada gerenciarVagoes = new ListaLigada();
            //Vagao vagao1 = new Vagao() { Id = 1, Carga = "Arroz", Peso = 10 };
            //Vagao vagao2 = new Vagao() { Id = 2, Carga = "Feijão", Peso = 15 };
            //Vagao vagao3 = new Vagao() { Id = 3, Carga = "Farinha", Peso = 20 };
            //Vagao vagao4 = new Vagao() { Id = 4, Carga = "Trigo", Peso = 25 };
            //Vagao vagao5 = new Vagao() { Id = 5, Carga = "Soja", Peso = 30 };
            //gerenciarVagoes.InserirVagao(vagao1);
            //gerenciarVagoes.InserirVagao(vagao2);
            //gerenciarVagoes.InserirVagao(vagao3);
            //gerenciarVagoes.InserirVagao(vagao4);
            //gerenciarVagoes.InserirVagao(vagao5);
            //foreach(Vagao item in gerenciarVagoes.getVagoes()) {
            //    Console.WriteLine("ID {0}", item.Id);
            //    Console.WriteLine("Carga {0}", item.Carga);
            //    Console.WriteLine("Peso {0}", item.Peso);
        }
    }
}