using System;

namespace Loja_de_Brinquedos28
{
    class Program
    {

        static void Main(string[] args)
        {
            Brinquedo brinquedo = new Brinquedo();
            Console.WriteLine("Insira o ID:");
            brinquedo.Id = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Insira o nome:");
            brinquedo.Nome = Console.ReadLine();

            Console.WriteLine("Insira a cor:");
            brinquedo.Cor = Console.ReadLine();

            Console.WriteLine("Insira a quatidade:");
            brinquedo.Quantidade = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Status do Usuário:\n 1-Ativo;\n 2-Inativo;");
            if (Convert.ToString(Console.ReadLine()) == "1")
            {

                brinquedo.Status = true;
            }
            else
            {
                brinquedo.Status = false;
            };


            Console.WriteLine("ID:" + brinquedo.Id);
            Console.WriteLine("Nome:" + brinquedo.Nome);
            Console.WriteLine("Cor:" + brinquedo.Cor);
            Console.WriteLine("Quantidade:" + brinquedo.Quantidade);
            Console.WriteLine("Status:" + brinquedo.Status);

            Console.ReadLine();

        }
    }
}
