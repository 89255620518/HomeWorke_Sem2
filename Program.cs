/*
int data = 24;
Console.WriteLine("Good morning! Today is " + data + "april");      //(""+...+"")
Console.WriteLine($"Good morning! Today is {data} april");   //($"...{...}...{..}..")
*/

//Задача№1
//Напишите программу, которая получает на вход двузначное число и показывает наибольшую цифру числа.

//Тип метода Имя метода (Аргументы)
/*
Тип метода: 
1. Возвратный:
bool, double, int:
*/
int Digits(int number)
{
    // 1. Выделить цифры числа
    int ed = number % 10;
    int dec = number / 10;
    // 2. Сравнить цифры
    if (ed > dec)
    {
        return ed;
    }
    else
    {
        return dec;
    }
    // 3. Сообщить Результат

}

Console.WriteLine("input number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

if(user_number < 100 && user_number > 9)
{
    int res = Digits(user_number);
    Console.WriteLine($"The biggest digit is {res}");
}
else
{
    Console.WriteLine("impossible value! ");
}