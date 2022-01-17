using System;
using System.Collections.Generic;
using System.Globalization;
using Generics3.Model;
using Generics3.Model.Services;
namespace Generics3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<cProduto> lista = new List<cProduto>();

            Console.Write("Quantidade de Elemento: ");
            int qtd = int.Parse(Console.ReadLine());

            for (int x = 0; x < qtd; x++)
            {

                Console.WriteLine("Produto e Preço: ");
                string[] Vet = Console.ReadLine().Split(",");

                string nome = Vet[0];
                double preco = double.Parse(Vet[1], CultureInfo.InvariantCulture);

                lista.Add(new cProduto(nome, preco));
            }

            foreach (cProduto l in lista)
            {
                Console.WriteLine(l);

            }

            Console.WriteLine(" Executando Serviço ");

            CalculationService calculationService = new CalculationService();

            cProduto max = calculationService.Max(lista);

            Console.WriteLine(max);

        }
    }
}
