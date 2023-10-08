namespace CursoDesignPatterns;

public class ISS : IImposto
{
    public double CalculaImposto(Orcamento orcamento)
    {
        return orcamento.Valor * 0.06;
    }    
}