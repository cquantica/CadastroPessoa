namespace CadastroPessoa
{
    public abstract class Pessoa
    {
        public string nome { get; set; }

        public Endereco endereco { get; set; }

        public bool enderecoComercial { get; set; }

        public float rendimento { get; set; }

        public abstract double PagarImposto(float salario);

    }


}



