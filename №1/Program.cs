//Задача 19: Напишите программу, которая принимает на вход
//пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());
string strnum = Convert.ToString(number);
int five = number%10000;

while ( number == five || number == five)
{
    Console.WriteLine("Неверное число, введите пятизначное ");
    int number2 = Convert.ToInt32(Console.ReadLine());    
}

if (strnum[0] == strnum[4] && strnum[1] == strnum[3])
{
    Console.WriteLine("Это число являеться палиндромом");
}
else 
{
        Console.WriteLine("Это число не являеться палиндромом");
}


