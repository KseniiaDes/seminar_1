//7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//456 -> 6
//782 -> 2
//918 -> 8


Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
if (number > 99 & number < 1000)
{
    int lastNum = number % 10;
    Console.WriteLine($"Последняя цифра числа: {lastNum}");
}
else
{
    Console.WriteLine("Ошибка ввода! Число не трехзначное");
}