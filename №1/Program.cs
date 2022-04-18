//Задача 19: Напишите программу, которая принимает на вход
//пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());
string strnum = Convert.ToString(number);
int[] arrayNum = new int[strnum.Length];
int m = number%100000;
while (strnum[0] == strnum[4] && strnum[1] == strnum[3])
{
    if ( number > m || m < number)
    {
        Console.WriteLine("Не то число введи пятизначное");
        break;
    }
    else
    {
        Console.WriteLine("это число не являеться палиндримом");
        break;
    }
Console.WriteLine("Число " + number + " являеться палиндримом");       
}
 



