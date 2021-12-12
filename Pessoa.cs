using System.IO;

namespace CadastroPessoaER2
{
    public abstract class Pessoa
    {
      public string nome { get; set; }
      
      public Endereco endereco { get; set; }    
      
      public float rendimento { get; set; }
       
      public abstract double PagarImposto(float salario);

      public void VerificarArquivo(string caminho){

        
        string pasta  = caminho.Split("/")[0];

        if (!Directory.Exists(pasta)) // Ponto de exclamação no começo do string inverte o sentido "Esta pasta não existe?"
        {
          Directory.CreateDirectory(pasta);
        }

        if (!File.Exists(caminho))
        {
          File.Create(caminho);
        }

        
      }
 
    }
}