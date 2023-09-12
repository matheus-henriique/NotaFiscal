using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("EMITIR NOTA FISCAL");
        Console.WriteLine("------------------------------------------------------------");

        bool continuar = true;

        while (continuar)
        {
            Console.Write("Digite 'F' para Pessoa Física ou 'J' para Pessoa Jurídica: ");
            string pessoa = Console.ReadLine();
            Console.WriteLine("------------------------------------------------------------");

            if (pessoa.Equals("F", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Digite o nome da Pessoa Física: ");
                string nomePessoaFisica = Console.ReadLine();
                Console.WriteLine("------------------------------------------------------------");

                Console.Write("Digite o CPF da Pessoa Física: ");
                string cpfPessoaFisica = Console.ReadLine();
                Console.WriteLine("------------------------------------------------------------");


                PessoaFisica pessoaFisica = new PessoaFisica(nomePessoaFisica, cpfPessoaFisica);

                Console.Write("Digite o número da Nota Fiscal: ");
                string numeroNotaFiscal = Console.ReadLine();
                Console.WriteLine("------------------------------------------------------------");


                NotaFiscal notaFiscal1 = new NotaFiscal(numeroNotaFiscal, pessoaFisica);


                Console.WriteLine("Detalhes da Nota Fiscal 1:");
                notaFiscal1.ImprimirDetalhes();
            }
            else if (pessoa.Equals("J", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Digite o nome da Pessoa Jurídica: ");
                string nomePessoaJuridica = Console.ReadLine();
                Console.WriteLine("------------------------------------------------------------");

                Console.Write("Digite o CNPJ da Pessoa Jurídica: ");
                string cnpjPessoaJuridica = Console.ReadLine();
                Console.WriteLine("------------------------------------------------------------");


                PessoaJuridica pessoaJuridica = new PessoaJuridica(nomePessoaJuridica, cnpjPessoaJuridica);

                Console.Write("Digite o número da Nota Fiscal: ");
                string numeroNotaFiscal = Console.ReadLine();
                Console.WriteLine("------------------------------------------------------------");


                NotaFiscal notaFiscal2 = new NotaFiscal(numeroNotaFiscal, pessoaJuridica);


                Console.WriteLine("Detalhes da Nota Fiscal 2:");
                notaFiscal2.ImprimirDetalhes();
                Console.WriteLine("------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("Opção inválido.");
                Console.WriteLine("------------------------------------------------------------");
            }

            Console.Write("Deseja emitir mais uma nota fiscal? (Sim/Não): ");
            string resposta = Console.ReadLine();
            Console.WriteLine("------------------------------------------------------------");

            if (!resposta.Equals("Sim", StringComparison.OrdinalIgnoreCase))
            {
                continuar = false;
            } 
        }

        Console.WriteLine("Fim.");
    }
}