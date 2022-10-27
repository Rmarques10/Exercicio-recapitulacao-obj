using Exercicio_recapitulacao_obj;
using System.Globalization;

Conta c;

Console.Write("Entre o número da conta: ");
int conta = int.Parse(Console.ReadLine());
Console.Write("Entre com nome titular da conta: ");
string nome = Console.ReadLine();
Console.Write("Haverá depósito inicial (s/n)? ");
char resp = char.Parse(Console.ReadLine());
if(resp == 's' || resp == 'S')
{
    Console.Write("Entre o valor de depósito inicial: ");
    double dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    c = new Conta(conta, nome, dep);
}
else
{
    c = new Conta(conta, nome);
}
Console.WriteLine();
Console.Write("Dados da conta: ");
Console.WriteLine(c);
Console.WriteLine();

Console.Write("Entre um valor para depósito: ");
double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
c.Depositar(valor);

Console.WriteLine();
Console.Write("Dados da conta atualizados:");
Console.WriteLine(c);
Console.WriteLine();

Console.Write("Entre um valor para depósito: ");
valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
c.Saque(valor);
Console.WriteLine();
Console.Write("Dados da conta atualizados:");
Console.WriteLine(c);
Console.WriteLine();