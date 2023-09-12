class PessoaFisica
{
    public string Nome { get; private set; }
    public string CPF { get; private set; }

    public PessoaFisica(string nome, string cpf)
    {
        Nome = nome;
        CPF = cpf;
    }
}