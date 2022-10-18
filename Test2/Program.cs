Console.WriteLine ("Введите число: ");

int number = int.Parse(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("третий цифры нет!");
}
else
{
    int coef = 10;

    if (number > 999)
    {
    while (true)
    {
        int third = number / coef;
        if (third > 100 && third < 1000)
        {
            break;
        }
        else 
        {
            coef *= 10;
        }
    }
    Console.WriteLine($"The third number is {(number / coef) % 10}");
    }
    else
    {
     Console.WriteLine($"The third number is {number % 10}");   
    }
}
