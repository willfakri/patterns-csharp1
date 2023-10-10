using System;
namespace CursoDesignPatterns
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            var valor = imposto.CalculaImposto(orcamento);
            Console.WriteLine(valor);
        }
    }
}