double a, b, c, delta, x1, x2;

Console.WriteLine ("-- Bhaskara --");

Console.Write("Insira o valor de [a]: ");
a = Convert.ToDouble(Console.ReadLine());

Console.Write("Insira o valor de [b]: ");
b = Convert.ToDouble(Console.ReadLine());

Console.Write("Insira o valor de [c]: ");
c = Convert.ToDouble(Console.ReadLine());

if (a == 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("A equação não é de segundo grau. Digite um valor de [a] não nulo.");
}
else
{
    delta =  Math.Pow(b, 2) - 4 * a * c;

    if(delta < 0)
    {
        Console.ForegroundColor= ConsoleColor.Red;
        Console.WriteLine("Esta equação não possui raizes reais.");
    }
    else
    {
        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        x2 = (-b + Math.Sqrt(delta)) / (2 * a);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"As raizes da equação são {x1:n1} e {x2:n1}.");
    }
}
Console.ResetColor();