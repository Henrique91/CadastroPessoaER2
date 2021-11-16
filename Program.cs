using System;
using System.Threading;

namespace CadastroPessoaER2
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(@$"     
=============================================
|    Bem Vindo ao sistema de cadastro de    |
|       pessoa Fisica e Juridica            |
=============================================
"); // "@" para aparencia de menu

            BarraCarregamento("Iniciando");


            string opcao;
            do
            {
                Console.WriteLine(@$"
            
==========================================
|       Escolha uma das opções abaixo    |
------------------------------------------
|           1- Pessoa Fisica             |
|           2- Pessoa Juridica           |
|                                        |
|           0- Sair                      |
==========================================
");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":

                        PessoaFisica pf = new PessoaFisica();
                        PessoaFisica novapf = new PessoaFisica();
                        Endereco endpf = new Endereco();

                        endpf.logradouro = "X";
                        endpf.complemento = "Proximo ao Senai Santa Cecilia";
                        endpf.enderecoComercial = false;

                        novapf.endereco = endpf;
                        novapf.cpf = "123456789";
                        novapf.nome = "Pessoa fisica";
                        novapf.dataNascimento = new DateTime(2000, 06, 12);

                        Console.WriteLine($"Rua: {novapf.endereco.logradouro}, numero: {novapf.endereco.numero}");

                        bool idadeValida = pf.ValidarDataNascimento(novapf.dataNascimento);

                        if (idadeValida == true)
                        {
                            Console.WriteLine($"Cadastro Aprovado!");

                        }
                        else
                        {
                            Console.WriteLine($"Cadastro reprovado!");

                        }
                        break;

                    case "2":

                        PessoaJuridica pj = new PessoaJuridica();

                        PessoaJuridica novaPj = new PessoaJuridica();

                        Endereco endpj = new Endereco();

                        endpj.logradouro = "X";
                        endpj.numero = 100;
                        endpj.complemento = "Proximo ao Senai Informatica";
                        endpj.enderecoComercial = true;

                        novaPj.endereco = endpj;
                        novaPj.cnpj = "34567890000199";
                        novaPj.razaoSocial = "Pessoa Juridica";

                        if (pj.ValidarCNPJ(novaPj.cnpj)) // Validação para saber se é true
                        {
                            Console.WriteLine("CNPJ Válido");
                        }
                        else
                        {
                            Console.WriteLine($"CNPJ Inválido");

                        }
                        break;

                    case "0":

                        Console.WriteLine($"Obrigado por utilizar nosso sistema!");
                        BarraCarregamento("Finalizando");


                        break;

                    default:
                        Console.WriteLine($"Opção invalida, digite uma opção válida");

                        break;
                }
            } while (opcao != "0"); //Irá se repetir enquanto for diferente de zero
        }
        static void BarraCarregamento(string textoCarregamento)
        {

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(textoCarregamento);
            Thread.Sleep(500);

            for (var contador = 0; contador < 10; contador++)   //Laço contado (estrutura de repetição)
            {

                Console.Write(".");
                Thread.Sleep(800);

            }
            Console.ResetColor();
        }
    }
}
