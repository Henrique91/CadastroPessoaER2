using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;

namespace CadastroPessoaER2
{
    class Program
    {
        static void Main(string[] args)

        {
            List<PessoaFisica> listapf = new List<PessoaFisica>();
            List<PessoaJuridica> listapj = new List<PessoaJuridica>();

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
|            PESSOA FISICA               |
|      1- Cadastrar pessoa fisica        |
|      2- Listar pessoa fisica           |
|      3- Remover pessoa fisica          |
------------------------------------------
|            PESSOA JURIDICA             |
|      4- Cadastrar pessoa Juridica      |
|      5- Listar pessoa Juridica         |
|      6- Remover pessoa Juridica        |
|                                        |
|      0- sair                           |
==========================================
");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":

                        PessoaFisica pf = new PessoaFisica();
                        PessoaFisica novapf = new PessoaFisica();
                        Endereco endpf = new Endereco();

                        // Console.WriteLine($"Digite seu logradouro");
                        // endpf.logradouro = Console.ReadLine(); //console.Readline() para o usuário escrever no console o que foi solicitado no string do cwl

                        // Console.WriteLine($"Digite o numero do seu endereço");
                        // endpf.numero = int.Parse(Console.ReadLine());

                        // /*No caso acima não é possível utilizar apenas o Readline, pois ele armazena tipo string.
                        //   É necessário fazer uma conversão para armazenar tipo int (numeo inteiro) utilizando o 
                        //   ==int.Parse== antes do console.readline */

                        // Console.WriteLine($"Digite um complemento (aperte enter para vazio)");
                        // endpf.complemento = Console.ReadLine();

                        // Console.WriteLine($"Este endereço é comercial? S/N");
                        // string endComercial = Console.ReadLine().ToUpper();
                        // /* Criado variavel para saber se o endereço é comercial Sim ou Nao.
                        //  Toupper converte caracter minusculo em maiusculo */

                        // if (endComercial == "S")
                        // {
                        //     endpf.enderecoComercial = true;
                        // }
                        // else
                        // {
                        //     endpf.enderecoComercial = false;
                        // }

                        // novapf.endereco = endpf;

                        // Console.WriteLine($"Digite seu CPF (somente numeros)");
                        // novapf.cpf = Console.ReadLine();

                        Console.WriteLine($"Digite seu nome");
                        novapf.nome = Console.ReadLine();


                        // Console.WriteLine($"Digite o valor do seu rendimento mensal (somente numeros)");
                        // novapf.rendimento = float.Parse(Console.ReadLine());
                        // /*Float.parse para converter string em float*/

                        // Console.WriteLine($"Digite sua data de nascimnto Ex: AAAA-MM-DD");
                        // novapf.dataNascimento = DateTime.Parse(Console.ReadLine());


                        // bool idadeValida = pf.ValidarDataNascimento(novapf.dataNascimento);

                        // if (idadeValida == true)
                        // {
                        //     Console.WriteLine($"Cadastro Aprovado!");
                        //     listapf.Add(novapf);
                        //     Console.WriteLine(pf.PagarImposto(novapf.rendimento));

                        // }
                        // else
                        // {
                        //     Console.WriteLine($"Cadastro reprovado!");
                        // }


                        // StreamWriter sw = new StreamWriter($"{novapf.nome}.txt"); //Criando arquvio .txt ( StreamWriter) utilizar biblioteca system.IO
                        // sw.Write(novapf.nome); // escrevendo dentro do arquivo
                        // sw.Close(); //Fechando o arquivo

                        using (StreamWriter sw = new StreamWriter($"{novapf.nome}.txt")) //utilização do using(), náo precisa usar o close daí ele fecha automaticamente
                        {
                            sw.Write(novapf.nome); // escrevendo dentro do arquivo 
                        }

                        using (StreamReader sr = new StreamReader($"{novapf.nome}.txt")) // Para ler
                        {
                            string linha;

                            while ((linha = sr.ReadLine()) != null)
                            {
                                Console.WriteLine($"{linha}");
                                
                            }
                             
                        }



                        break;

                        case "2":
                        foreach (var cadaitem in listapf)//estrutura de repetição para ler lista (foreach)
                        {
                            Console.WriteLine($"{cadaitem.nome},{cadaitem.cpf},{cadaitem.endereco.logradouro}");

                        }
                        break;

                        case "3":
                        Console.WriteLine($"Digite o cpf que deseja remover");
                        string cpfProcurado = Console.ReadLine();

                        PessoaFisica pessoaEncontrada = listapf.Find(cadaItem => cadaItem.cpf == cpfProcurado);

                        if (pessoaEncontrada != null)
                        {
                            listapf.Remove(pessoaEncontrada);
                            Console.WriteLine($"Cadastro Removido");

                        }
                        else
                        {
                            Console.WriteLine($"CPF não encontrado");

                        }

                        break;




                         case "4":

                        PessoaJuridica pj = new PessoaJuridica();

                        PessoaJuridica novaPj = new PessoaJuridica();

                        Endereco endpj = new Endereco();




                        Console.WriteLine($"Digite seu logradouro");
                        endpj.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o numero do seu endereço");
                        endpj.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite um complemento (aperte enter para vazio)");
                        endpj.complemento = Console.ReadLine();
                        

                        Console.WriteLine($"Este endereço é comercial? S/N");
                        string endComercialPj = Console.ReadLine().ToUpper();
                        /* Criado variavel para saber se o endereço é comercial Sim ou Nao.
                         Toupper converte caracter minusculo em maiusculo */

                        if (endComercialPj == "S")
                        {
                            endpj.enderecoComercial = true;
                        }
                        else
                        {
                            endpj.enderecoComercial = false;
                        }

                        novaPj.endereco = endpj;


                        Console.WriteLine($"Digite seu CNPJ (somente numeros)");
                        novaPj.cnpj = Console.ReadLine();

                        if (pj.ValidarCNPJ(novaPj.cnpj)) // Validação para saber se é true
                        {
                            Console.WriteLine("CNPJ Válido");

                        }

                        else
                        {
                            Console.WriteLine($"CNPJ Inválido");

                        }

                        Console.WriteLine($"Digite sua razão social");
                        novaPj.razaoSocial = Console.ReadLine();

                        Console.WriteLine($"Digite o valor do seu rendimento mensal (somente numeros)");
                        novaPj.rendimento = float.Parse(Console.ReadLine());
                        /*Float.parse para converter string em float*/

                        Thread.Sleep (500);
                        Console.WriteLine ( "Cadastro concluido");
                         listapj.Add (novaPj);
                        Thread.Sleep (500);
                        Console.WriteLine($"O valor do imposto é:");
                        Console.WriteLine ( pj.PagarImposto (novaPj.rendimento));

                        pj.VerificarArquivo(pj.caminho);
                        pj.Inserir(novaPj);

                        foreach (var item in pj.Ler())
                        {
                            Console.WriteLine($"Nome: {item.nome} - Razao Social:{item.razaoSocial} - CNPJ:{item.cnpj}");
                            
                        }
                        
                        

                        break;

                    case "5":

                        foreach (var cadaitem in listapj)//estrutura de repetição para ler lista (foreach)
                        {
                            Console.WriteLine($"{cadaitem.razaoSocial},{cadaitem.cnpj},{cadaitem.endereco.logradouro}");

                        }
                        break;

                    case "6":

                        Console.WriteLine($"Digite o CNPJ que deseja remover");
                        string cnpjProcurado = Console.ReadLine();

                        PessoaJuridica pessoaEncontradapj = listapj.Find(cadaItem => cadaItem.cnpj == cnpjProcurado);

                        if (pessoaEncontradapj != null)
                        {
                            listapj.Remove(pessoaEncontradapj);
                            Console.WriteLine($"Cadastro Removido");

                        }
                        else

                        {
                            Console.WriteLine($"CNPJ não encontrado");

                        }
                        break;

                    case "0":

                    Console.WriteLine($"Obrigado por utilizar nosso sistema!");
                         BarraCarregamento("Finalizando");

                    break;
                    default: 
                    
                    Console.WriteLine($"Opção invalida, digite uma opção válida!");

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
                Thread.Sleep(400);

            }
            Console.ResetColor();
        }
    }
}
