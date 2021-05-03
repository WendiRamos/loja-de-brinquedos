using System;

namespace Loja_de_Brinquedos28
{
    class Program
    {

        static void Main(string[] args)
        {
            Brinquedo brinquedo = new Brinquedo();
            Console.WriteLine("Insira o ID:");
            brinquedo.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o nome:");
            brinquedo.Nome = Console.ReadLine();

            Console.WriteLine("Insira a cor:");
            brinquedo.Cor = Console.ReadLine();

            Console.WriteLine("Insira a quatidade:");
            brinquedo.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Status do Usuário:\n 1-Ativo;\n 2-Inativo;");
            if (Console.ReadLine() == "1")
                brinquedo.Ativo = true;

            else
                brinquedo.Ativo = false;
          
            Console.WriteLine("ID:" + brinquedo.Id);
            Console.WriteLine("Nome:" + brinquedo.Nome);
            Console.WriteLine("Cor:" + brinquedo.Cor);
            Console.WriteLine("Quantidade:" + brinquedo.Quantidade);
            if (brinquedo.Ativo == true)
                Console.WriteLine("Status Ativo");
            else
                Console.WriteLine("Status Inativo");
            

            Console.ReadLine();

        }
    }
}
