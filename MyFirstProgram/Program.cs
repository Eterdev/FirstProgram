static int minNumber()
{
    Console.WriteLine("Подсчёт минимального значения/nВВедите 3 целых числа");
    string a = Console.ReadLine();
    string b = Console.ReadLine();
    string c = Console.ReadLine();
    a = System.Convert.ToInt32(a);
    b = System.Convert.ToInt32(b);
    c = System.Convert.ToInt32(c);
    int x;
    if (a < b) { x = a; }
    else x = b;
    if (c < x) return c;
    else return x;
}
Console.WriteLine(minNumber());

