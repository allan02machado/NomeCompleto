using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeCompleto;
            string nome;
            string sobreNome;

            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();
            
            Console.Write("Digite o seu sobrenome: ");
            sobreNome = Console.ReadLine();

            nomeCompleto = $"{nome} {sobreNome}";
            Console.WriteLine();
            Console.WriteLine("Presione uma tecla para gerar seu nome de catálogo...");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine($"Nome de catálogo: {sobreNome.ToUpper()} {nome}");
        }
    }
}
