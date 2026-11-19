try
{
    // 4a
    ClientePF cliente = new ClientePF();
    cliente.Telefone = "69 998078976";
    cliente.DataCadastro = new DateTime(2025, 12, 3);
    cliente.Nome = "João do teste";
    cliente.DataNascimento = new DateTime(1989, 9, 22);
    cliente.Cpf = "023.589.756-75";

    Servico servico = new Servico();
    servico.Descricao = "Troca de óleo";
    servico.ValorSugerido = 180;
    servico.TempoEstimado = 30;

    // 4b
    OrdemServico ordem = new OrdemServico(new DateTime(2025, 12, 3), "Aberto", 2, cliente);

    // 4c
    ItemServico item = new ItemServico();
    item.ValorUnitario = 180;
    item.Quantidade = 2;
    item.Ordem = ordem;
    item.Servico = servico;
    ordem.ListaItens.Add(item);

    // 4d
    Console.WriteLine($"Valor final da ordem: R$ {ordem.CalcularValorFinal():F2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}