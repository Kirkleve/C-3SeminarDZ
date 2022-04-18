// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 4, 9. 
//5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int numN= Convert.ToInt32(Console.ReadLine());
int index = 1;
while (index <= numN)
{
    int num = index*index*index;
    index++;
    Console.Write(" " + num);
}