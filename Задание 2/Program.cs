string a = "NULL";
string b = "NULL";
Console.WriteLine("Введите первое число (Первое число должно быть меньше второго)");
a = Console.ReadLine();
Console.WriteLine("Введите второе число");
b = Console.ReadLine();
int aa = Convert.ToInt32(a);
int bb = Convert.ToInt32(b);
if (aa < bb)
{
    Console.WriteLine("Если вы хотите чтобы я посчитал сумму всех чисел расположенных между данными числами на экран, введите 1 ");
    Console.WriteLine("Если вы хотите чтобы я вывел все нечетные значения, расположенные между данными числами, введите  2 ");
    string c = Console.ReadLine();
    int aaa = aa;
    int bbb = bb;
    switch (c)
    {
        case "1":
            {
                int d = 0;
                aaa++;
                while (aaa<bbb)
                {
                    d += aaa;
                    aaa++;
                }
                Console.WriteLine("Сумма всех чисел между {0} и {1} равна {2}", aa, bb, d);
                    break;
            }
        case "2":
            {
                aaa++;
                while (aaa<bbb)
                    {
                    if ((aaa & 1) == 1)
                        Console.Write("{0} ", aaa);
                    aaa++;
                }
                break;
            }
    }
}
else
    Console.WriteLine("Первое число не меньше второго");