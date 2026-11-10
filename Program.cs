using Heranca;

// Funcionario funcionario = new Funcionario(); 
Gerente gerente = new Gerente();

gerente.Nome = "Luiz";
gerente.Codigo = 123;
// gerente.Salario = 5000m;
gerente.DefinirSalario(5000m);

gerente.Trabalhar();
gerente.GerenciarEquipe();

Funcionario funcionario = new Gerente("Maria", 5000, 456); 

gerente.ExibirSalario();

Funcionario f1 = new Gerente();
Funcionario f2 = new Desenvolvedor(); 

f1.Trabalhar();
f2.Trabalhar(); 

Console.WriteLine(f1.CalcularBonus());
Console.WriteLine(f2.CalcularBonus());

IPagamento Pix = new PagamentoPix();
IPagamento Cartao = new PagamentoCartao();

Pix.Pagar(100m);
Cartao.Pagar(200m);