//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] FormArray (int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"Введите {i+1} число массива : ");
        array1[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array1;
}



int[] RandomArray ()
{
    int[] array2 = new int[8];
    for (int i = 0; i < array2.Length; i++)
    {
        array2[i] = new Random().Next(-999,1000);
    }
    return array2;
}

Console.WriteLine("Введите 1, если задаем массив в ручную, любая цифра, если заполним массив случайными числами от -999 до 999");
int choice = Convert.ToInt32(Console.ReadLine());

if (choice == 1)
{
    int[] array = new int[8];
    FormArray(array);
    Console.WriteLine ("Готовый массив : ");
    Console.Write(String.Join(" ", array));
 
}
else  
{ 
    Console.WriteLine ("Готовый массив : ");
    Console.Write(String.Join(" ", RandomArray()));
}
 