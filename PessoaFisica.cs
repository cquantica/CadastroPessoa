using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroPessoa
{
    public class PessoaFisica : Pessoa
    {

        public string cpf { get; set; }

        public DateTime dataNascimento { get; set; }

        // Adicionando Polimorfismo
        public override void PagarImposto(float salario){

        }

        public bool ValidarDataNascimento(DateTime dataNasc)
        {

            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - dataNasc).TotalDays / 365;

            if (anos >= 18)
            {

                return true;
            }
            return false;
        }









    }
}