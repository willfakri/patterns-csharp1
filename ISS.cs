namespace CursoDesignPatterns;

public class ISS
{
    public double CalculaISS(Orcamento orcamento)
    {
        return orcamento.Valor * 0.06;
    }
}