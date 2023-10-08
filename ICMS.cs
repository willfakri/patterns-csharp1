namespace CursoDesignPatterns;

public class ICMS
{
    public double CalculaICMS(Orcamento orcamento)
    {
        return orcamento.Valor * 0.1;
    }
}