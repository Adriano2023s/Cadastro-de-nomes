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
                Console.WriteLine("Opção 4: Deletar um item");
                Console.WriteLine("Opção 5: Adicionar um item em uma pozição específica");
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

                    case 4:
                        RemoveNome(nomes);
                        break;

                    case 5:
                        AdicionarEspessifico(nomes);
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
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (string.Compare(ListaNomes[j], ListaNomes[j + 1]) > 0)
                    {
                        string temp = ListaNomes[j];
                        ListaNomes[j] = ListaNomes[j + 1];
                        ListaNomes[j + 1] = temp;
                        break;
                    }
                }
            }
        }

        public static void RemoveNome(string[] ListaNomes)
        {
            Console.WriteLine("Digite a pozição que deseja remover");
            int pozicao = int.Parse(Console.ReadLine());

            if (pozicao > 0 && pozicao < ListaNomes.Length)
            {
                for (int i = 0; i < pozicao; i++)
                {
                    ListaNomes[i] = ListaNomes[i + 1];
                }
                ListaNomes[ListaNomes.Length - 1] = null;
                Console.WriteLine("Nome removido!");
            }
            else
            {
                Console.WriteLine("A pozição digitada não existe, tente novamente");
                return;
            }
        }

        public static void AdicionarEspessifico(string[] ListaNomes)
        {
            bool loopMenu = true;

            while (loopMenu)
            {
                Console.WriteLine($"Escolha uma pozição: (0 até {ListaNomes.Length - 1})");
                int pozicao = int.Parse(Console.ReadLine());

                if ( pozicao > 0 && pozicao <= ListaNomes.Length)
                {
                    Console.WriteLine("Digite o nome que deseja adicionar na lista:");
                    string nomeNovo = Console.ReadLine();

                    ListaNomes[pozicao] = nomeNovo;

                    Console.WriteLine($"O nome: {nomeNovo}, foi adicionado na pozição: {pozicao}");
                    loopMenu = false;
                }
                else
                {
                    Console.WriteLine("Pozição inválida, tente novamente outra pozição");
                    break;
                }
            }
        }
    }
}
