// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double [] arr =  {3, 7, 22, 2, 78};
//double [] arr =  {3, 7, 22, 0.2, 78, 83.8};

double max = arr[1];
double min = arr[0];
double result = 0;

for (int i = 0; i < arr.Length; i++)
{
    if(min >= arr[i])
    {
        min = arr[i]; 
    }
    if(max <= arr[i])
    {
        max = arr[i];
    } 
    result = max - min;
}
Console.WriteLine();
Console.WriteLine("[{0}] -> " + result, String.Join("; ", arr));
Console.WriteLine("Максимальный элемент: " + max);
Console.WriteLine("Минимальный элемент: " + min);
Console.WriteLine("Разница между элементами: " + result);
Console.WriteLine();