public abstract class Cliente
{
    public int Id { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    public DateTime DataCadastro { get; set; }

    public abstract double DescontoEspecial(double valor);
}

public class ClientePF : Cliente
{
    public string Cpf { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Nome { get; set; }

    public override double DescontoEspecial(double valor)
    {
        if (valor > 500 && valor < 1000)
            return valor - valor * 0.05;
        if (valor > 1000)
            return valor - valor * 0.07;
        return valor;
    }
}

public class ClientePJ : Cliente
{
    public string Cnpj { get; set; }
    public string NomeFantasia { get; set; }
    public string RazaoSocial { get; set; }

    public override double DescontoEspecial(double valor)
    {
        if (valor > 500 && valor < 1000)
            return valor - valor * 0.06;
        if (valor > 1000)
            return valor - valor * 0.09;
        return valor;
    }
}