// напишите программу, которая будет выдавать 
// название дня недели по заданному номеру:
//3 -> Среда
//5 -> Пятница

Console.Write("Введите день недели по порядку от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 1 ) Console.WriteLine("Первый день недели - Понедельник");
else if (a == 2 ) Console.WriteLine("Второй день недели - Вторник");
else if (a == 3 ) Console.WriteLine("Третий день недели - Среда");
else if (a == 4 ) Console.WriteLine("Четвертый день недели - Четверг");
else if (a == 5 ) Console.WriteLine("Пятый день недели - Пятница");
else if (a == 6 ) Console.WriteLine("Шестой день недели - Суббота");
else if (a == 7 ) Console.WriteLine("Седьмой день недели - Воскресенье");
else Console.WriteLine("Вы ввели день недели не верно, пожалуйста, попробуйте ввести еще раз");