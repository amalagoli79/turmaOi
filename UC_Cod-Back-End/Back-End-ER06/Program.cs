
using Back_End_ER02.Classes;
using Back_End_ER04.Classes;
using Back_End_ER06.Classes;

Console.Clear();

Utils.BarraCarregamento("Carregando");

string? opcao;
do
{
Console.Clear();
Console.WriteLine(@$"
================================================
|        Bem Vindo ao Sistema de Cadastro      |
|            Pessoa Física & Jurídica          |
================================================
|                                              |
|             1 - Pessoa Física                |
|                                              |
|             2 - Pessoa Jurídica              |
|                                              |
|             0 - Sair                         |
================================================
");

opcao = Console.ReadLine();

switch (opcao)
{
    case "1":
        Console.WriteLine($"Pessoa Fisica");

        PessoaFisica novaPF = new PessoaFisica();
        Endereco novoEndPf = new Endereco();
   
        novaPF.nome = "Adriano";
        novaPF.cpf = "2514521452";
        novaPF.rendimento = 6600.5f;
        novaPF.dataNasc = new DateTime(2000, 10, 01);

        novoEndPf.logradouro = "Rua Niteroi";
        novoEndPf.numero = 180;
        novoEndPf.complemento = "Escola Senai";
        novoEndPf.endComercial = true;

        novaPF.endereco = novoEndPf;

        Console.WriteLine(@$"
        Nome: {novaPF.nome}, 
        Rendimento: {novaPF.rendimento} 
        Cpf: {novaPF.cpf} 
        Logradouro: {novaPF.endereco.logradouro}
        Numero: {novaPF.endereco.numero}
        ");

        Thread.Sleep(5000);
        break;

    case "2":
        Console.WriteLine($"Pessoa Juridica");
        PessoaJuridica novaPj = new PessoaJuridica();
        Endereco novoEndPj = new Endereco();

        novaPj.nome = "Nome Pj";
        novaPj.razaoSocial = "Razão Social PJ";
        novaPj.cnpj = "00.476.645/0001-03";

        novoEndPj.logradouro = "Rua Niteroi";
        novoEndPj.numero = 180;

        novaPj.endereco = novoEndPj;

        Console.WriteLine(@$"
        Nome: {novaPj.nome}
        Razão Social: {novaPj.razaoSocial}
        CNPJ: {novaPj.cnpj} - Valido: {novaPj.ValidarCnpj(novaPj.cnpj)}
        ");
        
        Console.WriteLine($"Tecle Enter para sair");
        Console.ReadLine();
        break;

    case "0":
        Thread.Sleep(1000);
        Utils.BarraCarregamento("Finalizando");        
        break;

    default:
        Console.WriteLine($"Opção Inválida");
        Thread.Sleep(5000);
        break;
}


} while (opcao !="0");



















// Thread.Sleep(4000);
// Console.Clear();


// // Encontro Remoto 05
// PessoaJuridica novaPj = new PessoaJuridica();
// Endereco novoEndPj = new Endereco();

// novaPj.nome = "Nome Pj";
// novaPj.razaoSocial = "Razão Social PJ";
// novaPj.cnpj = "00.476.645/0001-03";

// novoEndPj.logradouro = "Rua Niteroi";
// novoEndPj.numero = 180;

// novaPj.endereco = novoEndPj;

// Console.WriteLine(@$"
// Nome: {novaPj.nome}
// Razão Social: {novaPj.razaoSocial}
// CNPJ: {novaPj.cnpj} - Valido: {novaPj.ValidarCnpj(novaPj.cnpj)}
// ");



//Console.WriteLine(novaPj.ValidarCnpj("00.476.045/0001-04"));

// Console.WriteLine(novaPF.nome);
// Console.WriteLine(novaPF.cpf);
// Console.WriteLine("Bem vindo");

// concatenação 
// Console.WriteLine("Bem vindo - " + novaPF.nome);

//interpolação
// Console.WriteLine($"Bem vindo: {novaPF.nome} de Cpf: {novaPF.cpf}");

// Pessoa Fisica =======================================================================
// float impostaPagar = novaPF.CalcularImposto (novaPF.rendimento);
// Console.WriteLine($"{impostaPagar:0.00}");
// Console.WriteLine(impostaPagar.ToString("C"));

// // Pessoa Juridica =========================================================================
// PessoaJuridica novaPj = new PessoaJuridica();
// Console.WriteLine(novaPj.CalcularImposto(6600.5f));

// var date1 = new DateTime(2008, 5, 1, 8, 30, 52);
// Console.WriteLine(date1);
// Console.WriteLine(date3);

// DateTime temp = new DateTime (2005, 01, 01);
// Console.WriteLine(novaPF.ValidarDataNasc("2004/12/24"));