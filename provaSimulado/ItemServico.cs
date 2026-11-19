public class ItemServico
{
    public int Id { get; set; }
    public double ValorUnitario { get; set; }
    public Servico Servico { get; set; }
    public OrdemServico Ordem { get; set; }

    private int _quantidade;
    public int Quantidade
    {
        get { return _quantidade; }
        set
        {
            if (value <= 0)
                throw new Exception("A quantidade deve ser maior que zero");
            _quantidade = value;
        }
    }
}