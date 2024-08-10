using System;

namespace AdicionaNome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[10];

            AddNome("Adriano", nome);
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
                    return;
                }
            }

        }
    }
}
