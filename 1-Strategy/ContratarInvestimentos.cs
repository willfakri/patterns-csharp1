namespace CursoDesignPatterns;

public class ContratarInvestimentos
{

    public void Contratar()
    {
        var conta = new Conta()
        {
            ValorSaldo = 10000
        };

        IProdutoInvestimento produto = new RendaFixa();
        produto.Contratar(500, conta);
    }    
}