using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroPessoa
{
    public class PessoaFisica : Pessoa
    {
        
        public string cpf { get; set;}

        public DateTime dataNascimento { get; set; }
    }
}