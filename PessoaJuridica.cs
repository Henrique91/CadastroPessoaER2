namespace CadastroPessoaER2
{
    public class PessoaJuridica :Pessoa //PessoaJuridica recebe herança da classe Pessoa
    {
        public string cnpj { get; set; }

        public string razaoSocial { get; set; }
        
        public override void PagarImposto(float salario){

        }
    }
}