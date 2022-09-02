// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int size = new Random().Next(5, 10);
int [] arr = new int [size];
int sum = 0;

for (int i = 0; i < size; i++)
{
    int numRandom = new Random().Next(-10, 30);
    arr[i] = numRandom;

    if(i % 2 == 1)
    { 
        sum += arr[i];  
    }
}

Console.WriteLine("[{0}] -> " + sum, String.Join(", ", arr));