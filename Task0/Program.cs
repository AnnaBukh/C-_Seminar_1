//выдать на экран пользователю "введите целое число 
Console.WriteLine("Введите целое число:");
//считываем ЦЕЛОЕ число 
int num = Convert.ToInt32(Console.ReadLine());// int: - 2 147 483 648 до 2 147 483 647
int square = num * num;
//вывод на экран
//Console.Write("Квадрат числа " + square);
//вывод на экран 
Console.Write($"Квадрат числа {num} = {square}");


