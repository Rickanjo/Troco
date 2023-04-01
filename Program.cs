// Solicite que o usuário digite o valor da compra e o valor pago. Exiba o valor do troco.

double ValorCompra;
double ValorPago;
double Troco;

Console.WriteLine("---Calculadora de Troco----\n");

Console.Write("Digite o valor da compra: ");
ValorCompra = double.Parse(Console.ReadLine()!);

Console.Write("Ddigite o valor pago: ");
ValorPago = double.Parse(Console.ReadLine()!);

Troco = ValorPago - ValorCompra;

Console.WriteLine($"\nO valor do troco é {Troco}");
Console.ReadLine();