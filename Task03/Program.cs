//3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница
Console.WriteLine("День недели по номеру");
Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1) Console.WriteLine("Это Понедельник!");
else if (number == 2) Console.WriteLine("Это Вторник!");
else if (number == 3) Console.WriteLine("Это Среда!");
else if (number == 4) Console.WriteLine("Это Четверг!");
else if (number == 5) Console.WriteLine("Это Пятница!");
else if (number == 6) Console.WriteLine("Это Суббота!");
else if (number == 7) Console.WriteLine("Это Воскресенье!");
else Console.WriteLine("Неправильно задано число!");