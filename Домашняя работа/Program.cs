//Задача№10
//Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.

//Пример
/*
456 -> 5
782 -> 8
918 -> 1
*/

// Решение:
/*
Console.WriteLine("input number: ");
int number = Convert.ToInt32(Console.ReadLine());
 for (int ii = 1; ii < 3 && (number <= 100 | number > 999); ii++)
{
     Console.Write(ii + " это не трёхзначное число, попробуйте ещё раз: ");
     number = Convert.ToInt32(Console.ReadLine());
}
if (number <= 100 | number > 999)
{
     Console.WriteLine(" программа прервана: ");
}
int res = number / 10 % 10;
Console.WriteLine($"{number} ->: {res}");
*/




//Задача№13
//Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//что третьей цифры нет.

//Пример:
/*
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

//Решение:
/*
Console.WriteLine("Enter a number:");
int num_1 = Convert.ToInt32(Console.ReadLine());
int num_2 = num_1.ToString().Length;
if (num_2 >= 3) {
	while (num_1 > 999)
	{
		num_1 = num_1 / 10;
	}
	int result = num_1 % 10;
	Console.WriteLine(value:$"{num_1} -> {result}");
} else {
	Console.WriteLine($"{num_1} -> третьей цифры нет");
}
*/

//Задача№15
//Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным.

//Пример:
/*
6 -> да
7 -> да
1 -> нет
*/

//Решение:
Console.WriteLine("Input your number: ");
int num_Ber = Convert.ToInt32(Console.ReadLine());
if (num_Ber < 7)
{
    Console.WriteLine($"{num_Ber} -> Да, вы правы");
}
else
{
    Console.WriteLine($"{num_Ber} -> Увы, нет такой день недели");
}
