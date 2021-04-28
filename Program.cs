using System;

namespace Loja_de_Brinquedos28
{
    class Program
    {

        static void Main(string[] args)
        {
            Brinquedo brinquedo = new Brinquedo();
            brinquedo.Id = 1318;
            brinquedo.Nome = "GlitterBall";
            brinquedo.Cor = "Azul";
            brinquedo.Quantidade = 28;
            brinquedo.Status = "Disponivel";
            Console.WriteLine("ID:" + brinquedo.Id);
            Console.WriteLine("Nome:" + brinquedo.Nome);
            Console.WriteLine("Cor:" + brinquedo.Cor);
            Console.WriteLine("Quantidade:" + brinquedo.Quantidade);
            Console.WriteLine("Status:" + brinquedo.Status);
            Console.ReadLine();

        }
    }
}
