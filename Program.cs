// See https://aka.ms/new-console-template for more information
namespace CursoDesignPatterns
    {
    class Program
    {
        static void Main(string[] args)
        {
            var orcamento = new Orcamento(10);
            var calculador = new CalculadorDeImpostos();

            IImposto icms = new ICMS();
            IImposto iss = new ISS();

            calculador.RealizaCalculo(orcamento, icms);
            calculador.RealizaCalculo(orcamento, iss);

            Console.ReadKey();
        }
    }
}