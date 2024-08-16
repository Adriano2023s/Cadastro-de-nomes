using System;

namespace AdicionaNome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("Opção 1: Adicionar um novo nome");
                Console.WriteLine("Opção 2: Imprimir a lista de nomes");
                Console.WriteLine("Opção 3: Ordenar por ordem alfabética");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        Console.WriteLine("Digite o nome que deseja adicionar");
                        string nome = Console.ReadLine();

                        AddNome(nome, nomes);

                        Console.WriteLine("Deseja continuar adicionando um nome? 's' para sim, ou 'n' para não.");
                        string resposta = Console.ReadLine();

                        if (resposta != "s")
                        {
                            continuar = false;
                            Console.WriteLine("Retornando para o menú");
                        }
                        break;


                    case 2:
                        ImprimeLista(nomes);
                        break;

                    case 3:
                        OrdenarNomes(nomes);
                        break;
                }
                }
            }

            public static void AddNome(string nome, string[] ListaNomes)
            {
                if (nome == null)
                {
                    Console.WriteLine("Nome inválido, tente novamente");
                    return;
                }

                for (int i = 0; i < ListaNomes.Length; i++)
                {
                    if (ListaNomes[i] == null)
                    {
                        ListaNomes[i] = nome;
                        Console.WriteLine($"O nome: {nome}, foi adicionado na pozição: {i}");
                    break;
                    }
                }
            }

            public static void ImprimeLista(string[] ListaNomes)
            {
                for (int i = 0; i < ListaNomes.Length; i++)
                {
                    if (!string.IsNullOrWhiteSpace(ListaNomes[i]))
                    {
                        Console.WriteLine($"Na pozição: {i}, {ListaNomes[i]}");
                                     }
                }
            }
       
    public static void OrdenarNomes(string[] ListaNomes)
        {
            int n = ListaNomes.Length;

            for (int i = 0; i < n - 1; i++)
            {
            for(int j = 0; j < ListaNomes.Length; j++)
                {
                    if (string.Compare(ListaNomes[j], ListaNomes[j + 1]) > 0)
                    {
                        string temp = ListaNomes[j];
                        ListaNomes[j] = ListaNomes[j + 1];
                        ListaNomes[j + 1] = temp;
                        return;
                    }
                }
            }
        }

        }
    }
     
        