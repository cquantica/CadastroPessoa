using System;

namespace CadastroPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            //   // Usado apenas para chamar os objetos
            // PessoaFisica pf = new PessoaFisica();

            //  // Para criar novo Endereço e Pessoa
            // PessoaFisica novaPf = new PessoaFisica();
            // Endereco end = new Endereco();

            // // Instanciando Endereco
            // end.logradouro = "Rua X";                 
            // end.numero = 100;
            // end.complemento = "Próximo ao Senai Santa cecilia";
            // end.enderecoComercial = false;

            // novaPf.endereco = end;
            // novaPf.cpf = "123456789";
            // novaPf.nome = "Pessoa fisica";
            // novaPf.dataNascimento = new DateTime(2000, 06, 15);

            // Console.WriteLine($@"Rua: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}");

            // bool idadeValida = pf.ValidarDataNascimento(novaPf.dataNascimento);

            //    if(idadeValida == true)
            // {
            //     Console.WriteLine($"Cadastro Aprovado");

            // }else
            // {
            //     Console.WriteLine($"Cadastro reprovado, não é permitido cadastro de usuário com menos de 18 anos");

            // }

            // Instancia a Pessoa Juridica e Chama Metodo
            PessoaJuridica pj = new PessoaJuridica();

            // Para Receber valor / Atributos
            PessoaJuridica novaPj = new PessoaJuridica();
            
            Endereco end = new Endereco();

            // Instanciando Endereco
            end.logradouro = "Rua X";
            end.numero = 100;
            end.complemento = "Proximo ao Senai Informatica";
            end.enderecoComercial = true;

            novaPj.endereco = end;
            novaPj.cnpj = "12345678900001";
            novaPj.RazaoSocial = "Pessoa Juridica";

            // Pessoa Fisica no bool 
            // Se a condiçao for true nao adiciona return true | Se for false no início da comparação adicionar o "!"
            if (pj.ValidarCNPJ(novaPj.cnpj))
            {
                Console.WriteLine("CNPJ Válido");
            }
            else
            {
                Console.WriteLine($"CNPJ Inválido");

            }
        }
    }

}
