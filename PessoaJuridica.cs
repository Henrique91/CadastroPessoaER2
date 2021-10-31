namespace CadastroPessoaER2
{
    public class PessoaJuridica :Pessoa //PessoaJuridica recebe herança da classe Pessoa
    {
        public string cnpj { get; set; }

        public string razaoSocial { get; set; }
        
        public override void PagarImposto(float salario){

        }

        public bool ValidarCNPJ(string cnpj){
            if (cnpj.Length == 14 && cnpj.Substring(cnpj.Length - 4) == "0001")
            {
                return true;
            }
                return false;
        }
    }
}