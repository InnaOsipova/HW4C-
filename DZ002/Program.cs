//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumNambers (int num)
{
    if (num == 0) return 0;
    return  (num % 10) + SumNambers(num/10);
    
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма всех цифр числа : "+SumNambers(number));
