using System;
namespace CursoDesignPatterns
{
    public class CalculadorDeImpostos
    {
        public CalculadorDeImpostos()
        {
            
        }
        public void RealizaCalculo(Orcamento orcamento)
        {
            double icms = orcamento.Valor * 0.1;
            Console.WriteLine(icms);

            double iss = orcamento.Valor * 0.06;
            Console.WriteLine(iss);
        }
    }
}