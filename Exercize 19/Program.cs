/*Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
14212 -> нет
12821 -> да
23432 -> да*/ 
Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
int num1 = number / 10000;
int num5 = number % 10;
int num2 = (number / 1000) % 10;
int num4 = (number % 100) / 10;
do
{
     if((num1 == num5) && (num2 == num4))
     {
           Console.WriteLine("да");
           break;
     }
     else 
     {
           Console.WriteLine("нет");
     }

} while (number > 10000 && number < 100000);
