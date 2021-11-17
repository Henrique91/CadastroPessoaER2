namespace CadastroPessoaER2
{
    public class PessoaJuridica :Pessoa //PessoaJuridica recebe herança da classe Pessoa
    {
        public string cnpj { get; set; }

        public string razaoSocial { get; set; }
        
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
    }
}