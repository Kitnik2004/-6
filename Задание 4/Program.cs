Console.WriteLine("Введите число клиентов");
int x = Convert.ToInt32(Console.ReadLine());

int result = 1;

do
{
    result *= x;
    x -= 1;
} while (x > 0);
Console.WriteLine("Количество вариантов доставки: {0}", result);