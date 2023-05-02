// Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }   

// int Even(int[] array)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) count++;
//     }
//     return count;
// }

// int size = new Random().Next(1,10);
// int min = new Random().Next(1,20);
// int max = new Random().Next(1,100);

// int[] myArray = CreateRandomArray(size, min, max);
// Console.WriteLine("Массив: ");
// ShowArray(myArray);
// Console.WriteLine("Количество четных чисел в массиве: " + Even(myArray));

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }
// void ShowArray(int[] array)

// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// } 

// int SumEven (int[] array)
// {
//     int sum = 0;
//     for(int i = 1; i < array.Length; i += 2) sum += array[i];
//     return sum;
// }

// int size = new Random().Next(1,10);
// int min = new Random().Next(1,20);
// int max = new Random().Next(1,100);

// int[] myArray = CreateRandomArray(size, min, max);
// Console.WriteLine("Массив: ");
// ShowArray(myArray);
// Console.WriteLine("Сумма элементов стоящих на нечётных позициях равна: " + SumEven(myArray));


//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}
void ShowArray(int[] array)

{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
} 

double MinMax(int[] array)
{
    double min = array[0];
    double max = array[0];
    double rez = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    rez = max - min;
    return rez;
}

Console.WriteLine("Ведите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минмальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);

Console.WriteLine("Массив: ");
ShowArray(myArray);
Console.WriteLine("Разница между мин и макс чисел в массиве равна: " + MinMax(myArray));


