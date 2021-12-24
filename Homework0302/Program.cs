int check()
{
    int result;
    bool flag = false;
    do
    {
        Console.Write($"Введите число: ");
        flag = int.TryParse(Console.ReadLine(), out result);
    } while (!flag);
    
    return result;
}

int count = 0;
int a;
List<int> Numbers = new List<int>();

do
{
    a = check();
    if (a > 0 && a % 2 != 0)
    Numbers.Add(a);
    count += a;
        
}while(a!=0);

Console.WriteLine("Нечетные числа: ");

foreach(int item in Numbers)
{
    Console.WriteLine(item);
}
Console.WriteLine(count);