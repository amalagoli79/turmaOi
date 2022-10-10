using Back_End_ER02.Classes;

PessoaFisica novaPF = new PessoaFisica();

novaPF.nome = "Adriano";
novaPF.cpf = "2514521452";
novaPF.rendimento = 6600.5f;

// Console.WriteLine(novaPF.nome);
// Console.WriteLine(novaPF.cpf);
// Console.WriteLine("Bem vindo");

// concatenação 
// Console.WriteLine("Bem vindo - " + novaPF.nome);

//interpolação
// Console.WriteLine($"Bem vindo: {novaPF.nome} de Cpf: {novaPF.cpf}");

// Pessoa Fisica =======================================================================
float impostaPagar = novaPF.CalcularImposto (novaPF.rendimento);
Console.WriteLine($"{impostaPagar:0.00}");
Console.WriteLine(impostaPagar.ToString("C"));

// Pessoa Juridica =========================================================================
PessoaJuridica novaPj = new PessoaJuridica();
Console.WriteLine(novaPj.CalcularImposto(6600.5f));





