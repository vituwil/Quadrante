double x, y;
string local;

Console.WriteLine("      Quadrante Cartesiano\n");

Console.WriteLine("Digite o ponto desejado.");

Console.Write("Coordenada x: ");
x = Convert.ToDouble(Console.ReadLine());

Console.Write("Coordenada y: ");
y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

if (x == 0 && y == 0) local = "a origem";

else if (x == 0) local = "o eixo das ordenadas";

else if (y == 0) local = "o eixo das abscissas";

else if (y > 0)
{
    if (x > 0)
        local = "o quadrante 1";
    else
        local = "o quadrante 2";
}
else
{
    if (x < 0)
        local = "o quadrante 3";
    else
        local = "o quadrante 4";
}

Console.Write($"O ponto ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"({x}, {y}) ");
Console.ResetColor();
Console.Write($"fica ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"n{local}.");
Console.ResetColor();