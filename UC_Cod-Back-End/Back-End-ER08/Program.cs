using CadastroPessoaBET6.Classes;

List<PessoaFisica> listaPf = new List<PessoaFisica>();

Console.Clear();
Console.WriteLine(@$"
=============================================
|    Bem vindo ao sistema de cadastro de    |
|        Pessoas Físicas e Juridícas        |
=============================================
");


Utils.BarraCarregamento("Iniciando", 100, 40);


string? opcao;
do
{
    Console.Clear();
    Console.WriteLine(@$"
=============================================
|        Escolha uma das opções abaixo      |
|-------------------------------------------|
|           1 - Pessoa Física               |
|           2 - Pessoa Juridíca             |
|                                           |
|           0 - Sair                        |
=============================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

            string? opcaoPf;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"
=============================================
|        Escolha uma das opções abaixo      |
|-------------------------------------------|
|           1 - Cadastrar Pessoa Física     |
|           2 - Listar Pessoa Física        |
|                                           |
|           0 - Voltar ao menu anterior     |
=============================================
");
                opcaoPf = Console.ReadLine();
                PessoaFisica metodosPf = new PessoaFisica();

                switch (opcaoPf)
                {
                    case "1":
                        Console.Clear();

                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEndPf = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa fisica, tecle Enter ao final");
                        novaPf.Nome = Console.ReadLine();

                        // bool dataValida;
                        // do
                        // {
                        //     Console.WriteLine($"Digite a data de nascimento Ex: DD/MM/AAAA");
                        //     string? dataNascimento = Console.ReadLine();

                        //     dataValida = novaPf.ValidarDataNasc(dataNascimento);

                        //     if (dataValida)
                        //     {
                        //         DateTime.TryParse(dataNascimento, out DateTime dataConvertida);
                        //         novaPf.dataNasc = dataConvertida;
                        //     }
                        //     else
                        //     {
                        //         Console.ForegroundColor = ConsoleColor.DarkRed;
                        //         Console.WriteLine($"Erro: Data inválida, digite um valor válido, Ex: DD/MM/AAAA");
                        //         Console.ResetColor();
                        //         Thread.Sleep(3000);
                        //     }

                        // } while (dataValida == false); //repeir laço 

                        // Console.WriteLine($"Digite o numero do CPF");
                        // novaPf.Cpf = Console.ReadLine();

                        // Console.WriteLine($"Digite o valor do rendimento mensal (somente numeros)");
                        // novaPf.Rendimento = float.Parse(Console.ReadLine());

                        // Console.WriteLine($"Digite o logradouro");
                        // novoEndPf.logradouro = Console.ReadLine();

                        // Console.WriteLine($"Digite o numero");
                        // novoEndPf.numero = int.Parse(Console.ReadLine());

                        // Console.WriteLine($"Digite o complemento");
                        // novoEndPf.complemento = Console.ReadLine();

                        // Console.WriteLine($"Este endereço é comercial? S ou N");
                        // String endCom = Console.ReadLine().ToUpper();

                        // if (endCom == "S")
                        // {
                        //     novoEndPf.endComercial = true;
                        // }
                        // else
                        // {
                        //     novoEndPf.endComercial = false;
                        // }

                        // novaPf.Endereco = novoEndPf;

                        // listaPf.Add(novaPf);

                        // Exemplo.1
                        // StreamWriter sw = new StreamWriter($"{novaPf.Nome}.txt");
                        // sw.WriteLine(novaPf.Nome);
                        // sw.Close();

                        using (StreamWriter sw = new StreamWriter($"{novaPf.Nome}.txt"))
                        {
                            sw.WriteLine(novaPf.Nome);
                        }



                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"Cadastro gravado");
                        Console.ResetColor();
                        Thread.Sleep(2000);



                        break;

                    case "2":
                        //                         Console.Clear();

                        //                         if (listaPf.Count > 0)
                        //                         {
                        //                             foreach (PessoaFisica cadaPessoa in listaPf)
                        //                             {
                        //                                 Console.Clear();
                        //                                 Console.WriteLine(@$"
                        // Nome: {cadaPessoa.Nome}
                        // Endereço: {cadaPessoa.Endereco.logradouro}, {cadaPessoa.Endereco.numero} - Compl.: {cadaPessoa.Endereco.complemento}
                        // Rend. Mensal: {cadaPessoa.Rendimento.ToString("C")}
                        // Imposto a ser pago: {metodosPf.PagarImposto(cadaPessoa.Rendimento).ToString("C")}
                        // Data Nasc.: {cadaPessoa.dataNasc.ToString("d")}
                        // ");
                        //                             Console.WriteLine($"Aperte ENTER para continuar");
                        //                             Console.ReadLine();
                        //                             }

                        //                         }
                        //                         else
                        //                         {
                        //                             Console.Clear();
                        //                             Console.ForegroundColor = ConsoleColor.Green;
                        //                             Console.WriteLine($"Lista vazia, cadastre uma nova P.F.");
                        //                             Console.ResetColor();
                        //                             Thread.Sleep(2000); 
                        //                         }

                        using (StreamReader sr = new StreamReader("Adriano.txt"))
                        {
                            string linha;

                            while ((linha = sr.ReadLine()) != null)
                            {
                                Console.WriteLine(linha);
                            }
                            Console.WriteLine($"Tecle Enter para continuar");
                            Console.ReadLine();

                        }


                        break;

                    case "0":
                        Console.Clear();
                        Console.WriteLine($"Voltando ao menu anterior");
                        Thread.Sleep(2000);
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opção Inválida, por favor digite uma opção válida");
                        Console.ResetColor();
                        Thread.Sleep(3000);

                        break;
                }


            } while (opcaoPf != "0");


            //             PessoaFisica novaPf = new PessoaFisica();
            //             PessoaFisica metodosPf = new PessoaFisica();
            //             Endereco novoEndPf = new Endereco();




            //             novaPf.Nome = "Fernando";
            //             novaPf.dataNasc = new DateTime(2000, 01, 01);
            //             novaPf.Cpf = "1234567890";
            //             novaPf.Rendimento = 3500.5f;

            //             novoEndPf.logradouro = "Alameda barao de limeira";
            //             novoEndPf.numero = 539;
            //             novoEndPf.complemento = "SENAI Informatica";
            //             novoEndPf.endComercial = true;

            //             novaPf.Endereco = novoEndPf;

            //             Console.Clear();
            //             Console.WriteLine(@$"
            // Nome: {novaPf.Nome}
            // Endereço: {novaPf.Endereco.logradouro}, {novaPf.Endereco.numero}
            // Maior de idade: {(metodosPf.ValidarDataNasc(novaPf.dataNasc) ? "Sim" : "Não")}
            // Imposto a ser pago: {metodosPf.PagarImposto(novaPf.Rendimento).ToString("C")}
            // ");
            //             // condicao ? "Sim" : "Não"

            //             // Console.WriteLine($"Nome: {novaPf.Nome} Nome: {novaPf.Nome}");
            //             // Console.WriteLine("Nome: " + novaPf.Nome + " Nome: " + novaPf.Nome);


            break;

        case "2":
            PessoaJuridica novaPj = new PessoaJuridica();
            PessoaJuridica metodosPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            novaPj.Nome = "Nome Pj2";
            novaPj.RazaoSocial = "Razão Social Pj2";
            novaPj.Cnpj = "00000000000122";
            novaPj.Rendimento = 10000.5f;

            novoEndPj.logradouro = "Alameda Barão de Limeira";
            novoEndPj.numero = 539;
            novoEndPj.complemento = "SENAI Informatica";
            novoEndPj.endComercial = true;

            novaPj.Endereco = novoEndPj;

            metodosPj.Inserir(novaPj);

            //             Console.Clear();
            //             Console.WriteLine(@$"
            // Nome: {novaPj.Nome}
            // Razão Social: {novaPj.RazaoSocial}
            // CNPJ: {novaPj.Cnpj}, Válido: {metodosPj.ValidarCnpj(novaPj.Cnpj)}
            // Endereço: {novaPj.Endereco.logradouro}, Nº: {novaPj.Endereco.numero}
            // Complemento: {novaPj.Endereco.complemento}
            // ");
            // Console.WriteLine($"Aperte ENTER para continuar");
            // Console.ReadLine();

            List<PessoaJuridica> listaExibicaoPJ = metodosPj.LerArquivo();

            foreach (PessoaJuridica cadaItem in listaExibicaoPJ)
            {
                Console.Clear();
                Console.WriteLine(@$"
Nome: {cadaItem.Nome}
Razão Social: {cadaItem.RazaoSocial}
// CNPJ: {cadaItem.Cnpj}
");

                Console.WriteLine($"Aperte ENTER para continuar");
                Console.ReadLine();
            }




            break;

        case "0":

            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar nosso sistema!");
            Thread.Sleep(3000);

            Utils.BarraCarregamento("Finalizando", 500, 6);

            break;

        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Opção Inválida, por favor digite uma opção válida");
            Console.ResetColor();
            Thread.Sleep(3000);
            break;
    }

} while (opcao != "0");


// static void BarraCarregamento(string texto, int tempo, int quantidade)
// {
//     Console.BackgroundColor = ConsoleColor.Green;
//     Console.ForegroundColor = ConsoleColor.Yellow;

//     Console.Write(texto);

//     for (var contador = 0; contador < quantidade; contador++)
//     {
//         Console.Write(".");
//         Thread.Sleep(tempo);
//     }

//     Console.ResetColor();
// }