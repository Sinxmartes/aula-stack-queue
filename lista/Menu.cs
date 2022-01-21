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
        public static ListaLigada listaReferencia = new ListaLigada();

        public static void main() {

            Console.ReadLine();
            Console.WriteLine("Escolha uma das opções...");
            Console.WriteLine("1. Adicionar um novo vagão");
            Console.WriteLine("2. Exibir o último vagão");
            Console.WriteLine("3. Exibir todos os vagões");
            Console.WriteLine("4. Buscar por id dentro do trem");
            Console.WriteLine("5. Buscar por nome dentro do trem");
            Console.WriteLine("6. Buscar por peso dentro do trem");
            Console.WriteLine("7. Editar vagão por id");
            Console.WriteLine("8. Deletar vagão por id");
            Console.WriteLine("0. Sair");
            Console.Write("Opção: ");

            switch (Console.Read())
            {
                case '1':
                    var novoVagao = new Vagao();

                    Console.ReadLine();
                    Console.WriteLine("Adicionando um novo vagão");
                    Console.WriteLine("Insira o Id do vagão");

                    novoVagao.Id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Insira o nome da Carga");

                    novoVagao.Carga = Console.ReadLine();

                    Console.WriteLine("Insira o peso da Carga");

                    novoVagao.Peso = Convert.ToInt32(Console.ReadLine());
                    
                    listaReferencia.InserirVagao(novoVagao);
                    break;
                case '2':
                    var ultimoVagao = listaReferencia.getUltimoVagao();

                    Console.WriteLine("Último vagão");
                    Console.WriteLine($"Carga: { ultimoVagao.Carga }");
                    Console.WriteLine($"Peso: { ultimoVagao.Peso }");
                    break;
                case '3':
                    foreach (Vagao item in listaReferencia.getVagoes())
                    {
                        Console.WriteLine("ID {0}", item.Id);
                        Console.WriteLine("Carga {0}", item.Carga);
                        Console.WriteLine("Peso {0}", item.Peso);
                    }
                    break;
                case '4':
                    Console.WriteLine("Insira o Id do vagão");

                    var id = Convert.ToInt32(Console.ReadLine());
                    var vagao = listaReferencia.getVagaoById(id);

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
                    Console.ReadLine();

                    var name = Console.ReadLine();
                    var listaVagoes = listaReferencia.getVagoesByName(name);

                    if (!listaVagoes.Any())
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
                case '6':
                    Console.WriteLine("Insira o peso");
                    Console.ReadLine();

                    var peso = Convert.ToInt32(Console.ReadLine());

                    var listaVagoesPeso = listaReferencia.getVagoesByPeso(peso);

                    if (!listaVagoesPeso.Any())
                    {
                        Console.WriteLine("Não foram encontrados nenhum vagão com esse peso");
                        break;
                    }

                    Console.WriteLine("Foram encontrados {0} vagões", listaVagoesPeso.Count);

                    foreach (var item in listaVagoesPeso)
                    {
                        Console.WriteLine("ID {0}", item.Id);
                        Console.WriteLine("Carga {0}", item.Carga);
                        Console.WriteLine("Peso {0}", item.Peso);
                    }
                    break;
                case '7':
                    Console.WriteLine("Insira o Id do vagão a ser editado");
                    Console.ReadLine();

                    var idEdit = Convert.ToInt32(Console.ReadLine());
                    var vagaoEdit = listaReferencia.getVagaoById(idEdit);

                    if (vagaoEdit == null)
                    {
                        Console.WriteLine("Não foi encontrado vagão com o Id informado.");

                        break;
                    }

                    Console.WriteLine("Insira o novo nome da Carga");

                    vagaoEdit.Carga = Console.ReadLine();

                    Console.WriteLine("Insira o novo peso da Carga");

                    vagaoEdit.Peso = Convert.ToInt32(Console.ReadLine());
                    break;
                case '8':
                    Console.WriteLine("Insira o Id do vagão a ser deletado");
                    Console.ReadLine();

                    var idDelete = Convert.ToInt32(Console.ReadLine());

                    listaReferencia.deleteById(idDelete);
                    break;
                case '0':
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção invalida, tente novamente...");
                    break;
            }
            main();
        }
    }
}