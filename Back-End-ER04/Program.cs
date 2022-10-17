
using Back_End_ER02.Classes;
using Back_End_ER04.Classes;

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