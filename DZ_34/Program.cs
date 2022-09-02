// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int size = new Random().Next(5, 10);
int count = 0;
int [] arr = new int [size];

for (int i = 0; i < arr.Length; i++)
{
    
    int numRandom = new Random().Next(100, 1000);
    arr[i] = numRandom;

    if(arr[i]%2 == 0)
    {
        count++;
    }
}

Console.WriteLine("[{0}] -> " + count, String.Join(", ", arr));