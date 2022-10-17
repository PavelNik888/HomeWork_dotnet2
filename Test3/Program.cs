Console.Write("Введите число соответстующий дню недели: ");
int num = int.Parse(Console.ReadLine());
switch (num)
{
    case 1: Console.WriteLine("Нет, это не выходной"); break;
    case 2: Console.WriteLine("Нет, это не выходной"); break;
    case 3: Console.WriteLine("Нет, это не выходной"); break;
    case 4: Console.WriteLine("Нет, это не выходной"); break;
    case 5: Console.WriteLine("Нет, это не выходной"); break;
    case 6: Console.WriteLine("Да, это не выходной"); break;
    case 7: Console.WriteLine("Да, это не выходной"); break;
    default: Console.WriteLine("ERROR"); break;
}
Console.ReadLine();
