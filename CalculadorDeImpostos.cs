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
                    var icms = new ICMS().CalculaICMS(orcamento);
                    Console.WriteLine(icms);
                    break;
                }
                case TipoImposto.ISS:
                {
                    var iss = new ISS().CalculaISS(orcamento);
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