//Задача 19: Напишите программу, которая принимает на вход
//пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());
string strnum = Convert.ToString(number);

if ( number > strnum[4] || strnum[4] > number)
{
    Console.WriteLine("Неверное число, введите пятизначное");
    Convert.ToInt32(Console.ReadLine());
}    
    if (strnum[0] == strnum[4] && strnum[1] == strnum[3])
    {
        Console.WriteLine("это число палиндрим");        
    }
    else
    {
        Console.WriteLine("это число не являеться палиндримом");
    } 





