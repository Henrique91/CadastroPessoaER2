using System;

namespace CadastroPessoaER2
{
    class Program
    {
        static void Main(string[] args)
        {
            // PessoaFisica pf = new PessoaFisica();
            // PessoaFisica novapf = new PessoaFisica();
            // Endereco end = new Endereco();

            // end.logradouro = "X";       
            // end.numero = 100;
            // end.complemento = "Proximo ao Senai Santa Cecilia";
            // end.enderecoComercial = false;

            // novapf.endereco = end;
            // novapf.cpf = "123456789";
            // novapf.nome = "Pessoa fisica";
            // novapf.dataNascimento = new DateTime(2015,06,12);

            // Console.WriteLine($"Rua: {novapf.endereco.logradouro}, numero: {novapf.endereco.numero}");
            
            // bool idadeValida = pf.ValidarDataNascimento(novapf.dataNascimento);

            // if (idadeValida == true)
            // {
            //     Console.WriteLine($"Cadastro Aprovado!");
                
            // }else
            // {
            //     Console.WriteLine($"Cadastro reprovado!");
                
            // }

            PessoaJuridica pj = new PessoaJuridica();

            PessoaJuridica novaPj = new PessoaJuridica();

            Endereco end = new Endereco();

            end.logradouro = "X";
            end.numero = 100;
            end.complemento = "Proximo ao Senai Informatica";
            end.enderecoComercial = true;

            novaPj.endereco = end;
            novaPj.cnpj = "12345678900001";
            novaPj.razaoSocial = "Pessoa Juridica";

            if (pj.ValidarCNPJ(novaPj.cnpj)) // Validação para saber se é true
            {
                Console.WriteLine("CNPJ Válido");
            }else
            {
                Console.WriteLine($"CNPJ Inválido");

            }


        }
    }
}
