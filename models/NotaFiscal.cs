class NotaFiscal
{
    public string Numero { get; private set; }
    public PessoaFisica PessoaFisica { get; private set; }
    public PessoaJuridica PessoaJuridica { get; private set; }

    public NotaFiscal(string numero, PessoaFisica pessoaFisica)
    {
        Numero = numero;
        PessoaFisica = pessoaFisica;
    }

    public NotaFiscal(string numero, PessoaJuridica pessoaJuridica)
    {
        Numero = numero;
        PessoaJuridica = pessoaJuridica;
    }

    public void ImprimirDetalhes()
    {
        Console.WriteLine($"Número da Nota Fiscal: NF{Numero}");
        if (PessoaFisica != null)
        {
            Console.WriteLine($"Pessoa Física Associada: {PessoaFisica.Nome}");
        }
        else if (PessoaJuridica != null)
        {
            Console.WriteLine($"Pessoa Jurídica Associada: {PessoaJuridica.RazaoSocial}");
        }
    }
}