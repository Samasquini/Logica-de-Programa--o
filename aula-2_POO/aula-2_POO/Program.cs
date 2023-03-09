/*Aluno matheus = new Aluno();
matheus.nome = "Matheus Silva";
Console.WriteLine("Digite a nota 1:");
matheus.nota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a nota 2:");
matheus.nota2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(matheus.nome);

matheus.CaucularMedia();
Console.WriteLine("\n");


Aluno Adalberto = new Aluno();
Adalberto.nome = "Adalberto Silva";
Console.WriteLine("Digite a nota 1:");
Adalberto.nota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a nota 2:");
Adalberto.nota2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Adalberto.nome);

Adalberto.CaucularMedia();
Console.WriteLine("\n");*/

using System.Security.Cryptography.X509Certificates;

Conta Usuario1 = new Conta();
Console.WriteLine("Usuario 1 digite seu nome:");
Usuario1.nome = Console.ReadLine().Split(" ");
Usuario1.tipo = "Corrente";
Console.Write($"{Usuario1.nome[0]}, digite seu saldo:" +
                                "\nR$ ");
var a1 = double.TryParse(Console.ReadLine(), out Usuario1.saldoTotal);


Conta Usuario2 = new Conta();
Console.WriteLine("Usuario 2 digite seu nome:");
Usuario2.nome = Console.ReadLine().Split(" ");
Usuario2.tipo = "Corrente";
Console.Write($"{Usuario2.nome[0]}, digite seu saldo:" +
                                "\nR$ ");
var a2 = double.TryParse(Console.ReadLine(), out Usuario2.saldoTotal);


Conta Usuario3 = new Conta();
Console.WriteLine("Usuario 3 digite seu nome:");
Usuario3.nome = Console.ReadLine().Split(" ");
Usuario3.tipo = "Corrente";
Console.Write($"{Usuario3.nome[0]}, digite seu saldo:" +
                                "\nR$ ");
var a3 = double.TryParse(Console.ReadLine(), out Usuario3.saldoTotal);


Console.Write("\n");
//string teste = Usuario3.nome[0];
//Ex.: Colocar Usuario3.nome[0] no metodo.
Usuario1.ConsultaConta();
Usuario2.ConsultaConta();
Usuario3.ConsultaConta();
Console.Write("\n");

Conta maiorSaldo = new Conta();
int mS = maiorSaldo.MaiorSaldo(Usuario1.saldoTotal, Usuario2.saldoTotal, Usuario3.saldoTotal);

if (mS == 1) Console.WriteLine($"Parabens {Usuario1.nome[0]}, você possui o maior saldo no banco.");
if (mS == 2) Console.WriteLine($"Parabens {Usuario2.nome[0]}, você possui o maior saldo no banco.");
if (mS == 3) Console.WriteLine($"Parabens {Usuario3.nome[0]}, você possui o maior saldo no banco.");