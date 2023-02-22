//Прямоугольник
for (int a = 1; a!= 10; a++)
{
    Console.Write("*");
}
Console.Write("\n");
for (int a = 1; a != 3; a++)
{
    Console.Write("*");
    for (int b = 1; b!=8; b++)
    {
        Console.Write(" ");
    }
    Console.Write("*");
    Console.Write("\n");
}
for (int a = 1; a != 10; a++)
{
    Console.Write("*");
}
Console.Write("\n");
Console.Write("\n");
//Прямоугольный треугольник

int i1 = 0, i2 = 0;
for (int a = 0; a < 8; a++)
{
    for (int b = 0; b < 9; b++)
    {

        if (b == i1 || b == i2) Console.Write("*");
        else Console.Write(" ");
    }
    Console.Write("\n");
    i2++;
}
for (int b = 0; b < 9; b++)
{
    Console.Write("*");
}
Console.Write("\n");
Console.Write("\n");
// Равносторонний треугольник
i1 = 0; i2 = 0;
for (int a = 0; a < 5; a++)
{
    for (int b= 0; b<9; b++)
    {
        if (b == i1 || b == i2) Console.Write("*");
        else Console.Write(" ");
    }
    Console.Write("\n");
    i2++;
}
for (int a = 0; a < 5; a++)
{
    for (int b = 0; b < 9; b++)
    {
        if (b == i1 || b == i2) Console.Write("*");
        else Console.Write(" ");
    }
    Console.Write("\n");
    i2--;
}
Console.Write("\n");
Console.Write("\n");


