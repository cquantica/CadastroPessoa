using System;
using System.IO;
using System.Threading;


namespace CadastroPessoa
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(@$"     
 =========================================
|       Bem vindo ao sistema de cadastro |
|       de pessoas                       |
|       Física e Jurídica                |
==========================================
");

            BarraCarregamento("Iniciando");

            string opcao;
            do
            {
                
                Console.WriteLine(@$"
===================================
| Selecione uma das opções abaixo |
| ------------------------------- |
| 1 - Pessoa Física               |
| 2 - Pessoa Jurídica             |
|                                 |
| 0 - Sair                        |
===================================
");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":

                        // Usado apenas para chamar os objetos
                        PessoaFisica pf = new PessoaFisica();

                        // Para criar novo Endereço e Pessoa
                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco endPF = new Endereco();

                        // Instanciando Endereco
                        endPF.logradouro = "Rua X";
                        endPF.numero = 100;
                        endPF.complemento = "Próximo ao Senai Santa cecilia";
                        endPF.enderecoComercial = false;

                        novaPf.endereco = endPF;
                        novaPf.cpf = "123456789";
                        novaPf.nome = "Pessoa fisica";
                        novaPf.dataNascimento = new DateTime(2000, 06, 15);

                        Console.WriteLine($@"Rua: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}");

                        bool idadeValida = pf.ValidarDataNascimento(novaPf.dataNascimento);

                        if (idadeValida == true)
                        {
                            Console.WriteLine($"Cadastro Aprovado");

                        }
                        else
                        {
                            Console.WriteLine($"Cadastro reprovado, não é permitido cadastro de usuário com menos de 18 anos");

                        }
                        break;

                    case "2":

                        // Instancia a Pessoa Juridica e Chama Metodo
                        PessoaJuridica pj = new PessoaJuridica();

                        // Para Receber valor / Atributos
                        PessoaJuridica novaPj = new PessoaJuridica();

                        Endereco endPJ = new Endereco();

                        // Instanciando Endereco
                        endPJ.logradouro = "Rua X";
                        endPJ.numero = 100;
                        endPJ.complemento = "Proximo ao Senai Informatica";
                        endPJ.enderecoComercial = true;

                        novaPj.endereco = endPJ;
                        novaPj.cnpj = "34567890000199";
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
                        break;

                    case "0":
                        Console.Clear();
                        Console.WriteLine($"Obrigado por usar nosso sistema");

                        BarraCarregamento("Finalizando");

                        break;

                    default:
                        Console.ResetColor();
                        Console.WriteLine($"Opção inválida, por favor digite uma opção válida");
                        break;
                }

            } while (opcao != "0");

        }

        static void BarraCarregamento(string textoCarregamento)
        {
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(textoCarregamento);
            Thread.Sleep(500);
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(".");
                Thread.Sleep(500);
            }
            Console.ResetColor();
        }


    }

}
