using Strategy.Fretes;
using System;

namespace Strategy
{
    class Program
    {
        enum TipoFrete
        {
            SemFrete = 0,
            Pac = 1,
            Sedex = 2
        }

        static void Main(string[] args)
        {
            TipoFrete frete = TipoFrete.SemFrete;

            var correios = new Correios();

            Console.WriteLine(@"Escolha o frete:
                                1 - PAC
                                2 - Sedex");
            var freteEscolhido = Console.ReadLine();

            Console.WriteLine(@"Informe a distancia");
            var distancia = Convert.ToInt32(Console.ReadLine());


            try
            {
                frete = (TipoFrete)Convert.ToInt32(freteEscolhido);
            }

            catch (Exception)
            {
                Console.WriteLine("Escolha informada não consta no cadastro de tipos de frete.");
            }

            if (frete == TipoFrete.Pac)
            {
                var valor = correios.CalculaFrete(distancia, new Pac());
                Console.WriteLine($"O valor Total do frete é:  R${valor}");
            }
            else if (frete == TipoFrete.Sedex)
            {
                var valor = correios.CalculaFrete(distancia, new Sedex());
                Console.WriteLine($"O valor Total do frete é:  R${valor}");
            }

            Console.ReadKey();
        }
    }
}
