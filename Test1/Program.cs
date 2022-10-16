Console.WriteLine ("Введите трехзначное число: ");

int number = int.Parse(Console.ReadLine());


int SecondN = (number % 100 - number % 10) / 10;

Console.WriteLine(SecondN);