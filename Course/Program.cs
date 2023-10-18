using Course;
using System.Globalization;

Console.WriteLine("Digite as medidas do triangulo X:");

Triangulo x, y;
x = new Triangulo();
y = new Triangulo();

x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


Console.WriteLine("Digite as medidas do triangulo Y:");

y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double p = (x.A + x.B + x.C) / 2;
double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

p = (yA + yB + yC) / 2;

double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

Console.WriteLine("Area de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Area de x = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

if (areaX > areaY) {
    Console.WriteLine("Maior area é a do X");
} else if (areaY > areaX) {
    Console.WriteLine("Maior area é a do Y");
} else {
    Console.WriteLine("As areas tem valores iguais.");
}