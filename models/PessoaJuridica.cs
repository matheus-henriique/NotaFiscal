class PessoaJuridica
{
    public string RazaoSocial { get; private set; }
    public string CNPJ { get; private set; }

    public PessoaJuridica(string razaoSocial, string cnpj)
    {
        RazaoSocial = razaoSocial;
        CNPJ = cnpj;
    }
}