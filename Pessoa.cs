using System.IO;

namespace CadastroPessoa
{
    public abstract class Pessoa
    {
        public string nome { get; set; }

        public Endereco endereco { get; set; }

        public bool enderecoComercial { get; set; }

        public float rendimento { get; set; }

        public abstract double PagarImposto(float salario);

        public void VerificarArquivo(string Caminho) {
            string pasta = Caminho.Split("/")[0];
            
            if (!Directory.Exists(pasta))
            {
           
            Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(Caminho))
            {
                File.Create(Caminho);
            }
            

        }

    }


}



