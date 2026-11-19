public class OrdemServico
{
    public int Id { get; set; }
    public DateTime DataInicio { get; set; }
    public List<ItemServico> ListaItens { get; set; }
    public string Status { get; set; }
    public double PorcentagemDesconto { get; set; }
    public double ValorFinal { get; set; }
    public Veiculo Veiculo { get; set; }
    public Cliente Cliente { get; set; }

    public OrdemServico(DateTime dataInicio, string status, double porcentagemDesconto, Cliente cliente)
    {
        DataInicio = dataInicio;
        Status = status;
        PorcentagemDesconto = porcentagemDesconto;
        Cliente = cliente;
        ListaItens = new List<ItemServico>();
        CalcularValorFinal();
    }

    public double CalcularValorFinal()
    {
        double total = 0;
        foreach (ItemServico item in ListaItens)
        {
            total += item.ValorUnitario * item.Quantidade;
        }

        total = total - (total * PorcentagemDesconto / 100);
        total = Cliente.DescontoEspecial(total);

        ValorFinal = total;
        return ValorFinal;
    }
}