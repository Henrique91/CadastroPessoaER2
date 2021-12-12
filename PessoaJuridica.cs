using System.Collections.Generic;
using System.IO;

namespace CadastroPessoaER2
{
    public class PessoaJuridica :Pessoa //PessoaJuridica recebe herança da classe Pessoa
    {
        public string cnpj { get; set; }

        public string razaoSocial { get; set; }

        public string caminho {get; private set; } = "Database/PessoaJuridica.csv";
        
        public override double PagarImposto(float rendimento){
            if (rendimento <= 5000)
            {
                return rendimento*0.06;
            
            }else if(rendimento > 5000 && rendimento <= 10000)
            {
                return rendimento * 0.08;
            }else
            {
                return (rendimento/100) * 10;
            }


        }

        public bool ValidarCNPJ(string cnpj){
            if (cnpj.Length == 14 && cnpj.Substring(cnpj.Length - 6, 4) == "0001")
            {
                return true;
            }
                return false;
        }


        public string PrepararLinhasCsv(PessoaJuridica pj){

            return $"{pj.cnpj};{pj.endereco};{pj.razaoSocial}";
        }
        public void Inserir(PessoaJuridica pj){

            string[] linhas = {PrepararLinhasCsv(pj)};

            File.AppendAllLines(caminho, linhas);
        }

        public List<PessoaJuridica> Ler(){
         
         List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

         string[] linhas = File.ReadAllLines(caminho);

         foreach (var cadaLinha in linhas)
         {
             string[] atributos = cadaLinha.Split(";");

             PessoaJuridica cadaPj = new PessoaJuridica();

             cadaPj.cnpj = atributos[0];
             cadaPj.nome = atributos[1];
             cadaPj.razaoSocial = atributos[2];

             listaPj.Add(cadaPj);

             }
            
            return listaPj;
        }
    }
}