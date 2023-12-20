

// Задача 1.  Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых
//            лежат в отрезке [20,90].

// int[] array = new int[10];
 
// for(int i = 0; i < array.Length; i++) 
// {
//     array[i] = new Random().Next(1,101);
//     System.Console.Write(array[i]+ " ");
// }   
// Console.WriteLine();

// int lowerBound = 20;
// int upperBound = 90;
// int count = CountElementsINInterval(array, lowerBound, upperBound);

// Console.WriteLine($"Количество элементов в отрезке [{20}, {90}]: {count}");

// static int CountElementsINInterval(int[] arr, int lowerBound, int upperBound)

// {
//     int count = 0;
//     foreach(int element in arr)
//     {
//         if(element >= lowerBound && element <= upperBound)
//         {
//             count++;
//         }
//     }
//     return count;
// }


// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.
// Примеры:
// [6 7 19 34 3 1 4 7 9 1] => 3
// [1 8 43 4 55 60 3 2 1 3] => 4

//   int[] array = new int[10];       
 
//   for(int i = 0; i < array.Length; i++) 
//   {
//       array[i] = new Random().Next(1, 100);
//       System.Console.Write(array[i]+ " ");
//   } 
//   Console.WriteLine();

//   int evenCount = CountEvenNumbers(array);
//   Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");

//   static int CountEvenNumbers(int[] array)
//   {
//     int evenCount = 0;
//     foreach(int number in array)
//     {
//         if(number %2 == 0)
//         {
//             evenCount++;
//         }
//     }
//     return evenCount;
//   }


// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.
// Примеры:
// [2.2 0.4 9.11 7.2 78.98] => 78.58
// [1.22 4.5 3.33] => 3.28


    Random random = new Random();
    int arraySize = 5;
    double[] realNumbers = new double[arraySize];

    for(int i = 0; i < arraySize; i++) 
    {
        realNumbers[i] = Math.Round(random.NextDouble() *10, 2);
    }
    Console.WriteLine("Сгенерированный массив случайнных чисел");
    foreach(double number in realNumbers)
    {
         Console.WriteLine(number);
    }
    Console.WriteLine();

    double maxNumber = FindMax(realNumbers);
    double minNumber = FindMin(realNumbers);
    double difference = maxNumber - minNumber;

    Console.WriteLine($"Максимальный элемент: {maxNumber}");
    Console.WriteLine($"Минимальный элемент: {minNumber}");
    Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");
    

    static double FindMax(double[] arr)
    {
        double max = arr[0];

        foreach (double num in arr)
        {
            if(num > max)
            {
                max = num;
            }
        }
        return max;
    }

    static double FindMin(double[] arr)
    {
        double min = arr[0];

        foreach (double num in arr)
        {
            if(num < min)
            {
                min = num;
            }
        }
        return min;
    }
    