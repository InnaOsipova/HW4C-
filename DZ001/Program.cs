// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void Exponentiation (int number1, int number2)
{
    Console.WriteLine($"{number1} в степени {number2} = {Math.Pow(number1, number2)}");
}

Console.Write("Введите число которе нужно возвести в степень : ");
int arg1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа : ");
int arg2 = Convert.ToInt32(Console.ReadLine());
Exponentiation(arg1, arg2);
