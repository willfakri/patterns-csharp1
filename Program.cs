// See https://aka.ms/new-console-template for more information
namespace CursoDesignPatterns
    {
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var calculador = new CalculadorDeImpostos();
            calculador.RealizaCalculo(new Orcamento(10), TipoImposto.ICMS);
            calculador.RealizaCalculo(new Orcamento(10), TipoImposto.ISS);

            Console.ReadKey();
        }
    }
}