using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;



namespace CadastroPessoa
{
    class Program
    {
        static void Main(string[] args)
        {

            List<PessoaFisica> listaPf = new List<PessoaFisica>();
            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

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
|       Pessoa Física             |
| 1- Cadastrar Pessoa Física      |
| 2- Listar Pessoa Física         |
| 3- Remover Pessoa Física        |
|                                 |
|       Pessoa Jurídica           |
| 4- Cadastrar Pessoa Jurídica    |
| 5- Listar Pessoa Jurídica       |
| 6- Remover Pessoa Jurídica      |
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


                        // //Instanciando Pessoa
                        // novaPf.endereco = endPF;

                        // Console.WriteLine($"Digite seu CPF (somente números)");
                        // novaPf.cpf = Console.ReadLine();

                        Console.WriteLine($"Digite seu nome");
                        novaPf.nome = Console.ReadLine();

                        // Console.WriteLine($"Digite o valor do seu rendimento mensal (somente números)");
                        // novaPf.rendimento = float.Parse(Console.ReadLine());

                        // Console.WriteLine($"Digite sua data de nascimento. Exemplo aaaa-mm-dd");
                        // novaPf.dataNascimento = DateTime.Parse(Console.ReadLine());

                        // Console.WriteLine($@"Rua: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}");

                        // bool idadeValida = pf.ValidarDataNascimento(novaPf.dataNascimento);

                        // if (idadeValida == true)
                        // {
                        //     Console.WriteLine($"Cadastro Aprovado");
                        //     listaPf.Add(novaPf);
                        //     Console.WriteLine(pf.PagarImposto(novaPf.rendimento));

                        // }
                        // else
                        // {
                        //     Console.WriteLine($"Cadastro reprovado, não é permitido cadastro de usuário com menos de 18 anos");

                        // }

                        // // Instanciando Endereco
                        // Console.WriteLine($"Digite seu logradouro");
                        // endPF.logradouro = Console.ReadLine();

                        // Console.WriteLine($"Digite o número");
                        // endPF.numero = int.Parse(Console.ReadLine());

                        // Console.WriteLine($"Digite o Complemento (Aperte ENTER para vazio)");
                        // endPF.complemento = Console.ReadLine();

                        // Console.WriteLine($"Este é endereço comercial? S/N ");
                        // string enderecoComercial = Console.ReadLine().ToUpper();

                        // if (enderecoComercial == "S")
                        // {
                        //     endPF.enderecoComercial = true;
                        // }
                        // else
                        // {
                        //     endPF.enderecoComercial = false;
                        // }

                        // using (StreamWriter sw = new StreamWriter($"{novaPf.nome}.txt"))
                        // {
                        //     sw.Write($"{novaPf.nome}");
                        //     sw.Close();

                        // }

                        using (StreamReader sr = new StreamReader($"{novaPf.nome}.txt"))
                        {
                            string linha;

                            while ((linha = sr.ReadLine()) != null)
                            {
                                Console.WriteLine($"{linha}");
                            }
                        }


                        break;

                    case "2":

                        foreach (var cadaItem in listaPf)
                        {
                            Console.WriteLine($"Nome: {cadaItem.nome}");
                            Console.WriteLine($"CPF: {cadaItem.cpf}");
                            Console.WriteLine($"Logradouro: {cadaItem.endereco.logradouro}");
                            Console.WriteLine($"Numero: {cadaItem.endereco.numero}");
                            Console.WriteLine($"Rendimento: {cadaItem.rendimento}");
                        }


                        break;

                    case "3":

                        Console.WriteLine($"Digite o CPF que deseja remover");
                        string cpfProcurado = Console.ReadLine();

                        PessoaFisica pessoaEncontrada = listaPf.Find(cadaItem => cadaItem.cpf == cpfProcurado);

                        if (pessoaEncontrada != null)
                        {
                            listaPf.Remove(pessoaEncontrada);
                            Console.WriteLine($"Cadastro Removido!");
                        }
                        else
                        {
                            Console.WriteLine($"CPF não encontrado!");
                        }
                        break;

                    case "4":

                        // Instancia a Pessoa Juridica e Chama Metodo
                        PessoaJuridica pj = new PessoaJuridica();

                        // Para Receber valor / Atributos
                        PessoaJuridica novaPj = new PessoaJuridica();

                        Endereco endPJ = new Endereco();

                        Console.WriteLine($"Digite Seu Logradouro");
                        endPJ.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o Numero");
                        endPJ.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento (Aperte ENTER para vazio)");
                        endPJ.complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereco é Comercial ? S/N");
                        string enderecoComercialPJ = Console.ReadLine().ToUpper();

                        if (enderecoComercialPJ == "S")
                        {
                            endPJ.enderecoComercial = true;
                        }
                        else
                        {
                            endPJ.enderecoComercial = false;


                        }
                        novaPj.endereco = endPJ;

                        Console.WriteLine($"Digite seu CNPJ (somente números)");
                        novaPj.cnpj = Console.ReadLine();


                        // Pessoa Juridica no bool 
                        // Se a condiçao for true nao adiciona return true | Se for false no início da comparação adicionar o "!"
                        if (pj.ValidarCNPJ(novaPj.cnpj))
                        {
                            Console.WriteLine("CNPJ Válido");

                        }
                        else
                        {
                            Console.WriteLine($"CNPJ Inválido");
                        }

                        Console.WriteLine($"Digite sua Razão Social");
                        novaPj.RazaoSocial = Console.ReadLine();

                        Console.WriteLine($"Digite seu rendimento mensal (somente números)");
                        novaPj.rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine("Cadastro Concluído");
                        listaPj.Add(novaPj);
                        Console.WriteLine($"O valor do Desconto do imposto é de {pj.PagarImposto(novaPj.rendimento).ToString("")} reais");
                        // Console.WriteLine(pj.PagarImposto(novaPj.rendimento).ToString("N2"));

                        pj.VerificarArquivo(pj.Caminho);
                        pj.Inserir(novaPj);

                        if (pj.Ler().Count > 0)
                        {
                            foreach (var item in pj.Ler())
                            {
                                Console.WriteLine($"Nome: {item.nome} - Razão social: {item.RazaoSocial} - CNPJ:{item.cnpj}");
                            }

                        }
                        else
                        {
                            Console.WriteLine($"Lista vazia");

                        }

                        break;

                    case "5":

                        Console.Clear();
                        PessoaJuridica verificadorpj = new PessoaJuridica();

                        if (verificadorpj.Ler().Count > 0)

                        {
                            foreach (var item in verificadorpj.Ler())
                            {
                                Console.WriteLine($"Nome: {item.nome} - Razao Social: {item.RazaoSocial} - CNPJ: {item.cnpj}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Lista vazia");
                        }

                        Console.WriteLine($"Aperte enter para continuar");
                        Console.ReadLine();

                        break;

                    case "6":

                        Console.WriteLine($"Digite o CNPJ que deseja remover");
                        string cnpjProcurado = Console.ReadLine();

                        PessoaJuridica pessoaJEncontrada = listaPj.Find(cadaItem => cadaItem.cnpj == cnpjProcurado);

                        if (pessoaJEncontrada != null)
                        {
                            listaPj.Remove(pessoaJEncontrada);
                            Console.WriteLine($"Cadastro Removido!");
                        }
                        else
                        {
                            Console.WriteLine($"CNPJ não encontrado!");


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
            for (var contador = 0; contador < 5; contador++)
            {
                Console.WriteLine(".");
                Thread.Sleep(300);
            }
            Console.ResetColor();
        }
    }
}
