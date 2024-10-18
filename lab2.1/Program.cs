try
{
    Console.WriteLine("Введите трехзначное число");
    int x = int.Parse(Console.ReadLine());
    int c = x % 10;
    int b = x % 100 / 10;
    int a = x / 100;
    if ((a==b)&&(b==c)) Console.WriteLine("Все цифры одинаковы");
    else Console.WriteLine("Цифры не одинаковы");
    if ((c == b) || (c == a) || (a == b)) Console.WriteLine("Есть одинаковые цифры");
    else Console.WriteLine("Нет одинаковых цифры");
}
catch
{
    Console.WriteLine("Правильно введите данные");
}
