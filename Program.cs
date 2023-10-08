// See https://aka.ms/new-console-template for more information
namespace CursoDesignPatterns
    {
    class Program
    {
        static void Main(string[] args)
        {
            var orcamento = new Orcamento(10);
            var calculador = new CalculadorDeImpostos();
            calculador.RealizaCalculo(orcamento, TipoImposto.ICMS);
            calculador.RealizaCalculo(orcamento, TipoImposto.ISS);

            Console.ReadKey();
        }
    }
}