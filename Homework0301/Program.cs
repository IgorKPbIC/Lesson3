Complex z1 = new Complex(1, -8);
System.Console.WriteLine($"Первое комплексное число: " + z1);

Complex z2 = new Complex(-3, -4);
System.Console.WriteLine($"Второе комплексное число: " + z2);

Console.WriteLine("Выберете необходимое действие: 1 - сложение, 2- вычитание, 3 - деление");
int choose = int.Parse(Console.ReadLine());
switch (choose)
{
    case 1:
        Complex z3;
        z3=z1.Sum(z2);
        Console.WriteLine(z3);
        break;
    case 2:
        Complex z4;
        z4=z1.Sub(z2);
        Console.WriteLine(z4);
        break;
    case 3:
        Complex z5;
        z5=z1.Prod(z1, z2);
        Console.WriteLine(z5);
        break;
}

