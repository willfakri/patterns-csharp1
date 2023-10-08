using System;
namespace CursoDesignPatterns
{
    public class CalculadorDeImpostos
    {
        public CalculadorDeImpostos()
        {
            
        }
        public void RealizaCalculo(Orcamento orcamento, TipoImposto tipoImposto)
        {
            switch (tipoImposto)
            {
                case TipoImposto.ICMS:
                {
                    double icms = orcamento.Valor * 0.1;
                    Console.WriteLine(icms);
                    break;
                }
                case TipoImposto.ISS:
                {
                    double iss = orcamento.Valor * 0.06;
                    Console.WriteLine(iss);
                    break;
                }
                default:
                    Console.WriteLine("Tipo de imposto não suportado.");
                    break;
            }
        }
    }
}