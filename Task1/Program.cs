//выдать на экран пользователю "введите целое число 
//Console.WriteLine("Введите целое число:");
//считываем ЦЕЛОЕ число 
//int num = Convert.ToInt32(Console.ReadLine());// int: - 2 147 483 648 до 2 147 483 647
//int square = num * num;
//вывод на экран
//Console.Write("Квадрат числа " + square);
//вывод на экран 
//Console.Write($"Квадрат числа {num} = {square}");

//if (num == 5 && num == 7) // == сравнение, &&  логическое сложение (если num=5 b num = 7)
//{

//}
//else if (num == 6 || num ! = 3) // || - или (если num равен 6 или num не равно 3)
//{

//}

Console.Write("Введите целое чило: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите еще одно целое число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b*b ==a ) 
    Console.WriteLine($"число {a} является квадратом числа {b} ");
else 
    Console.WriteLine($"число {a} не является квадратом числа {b} ");