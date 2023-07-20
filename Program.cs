// Задача 34
// using System;

// class Program
// {
//     static void Main()
//     {
//         int[] numbers = new int[4]; 
//         Random random = new Random();

//         for (int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = random.Next(100, 1000);
//         }

//         Console.WriteLine("Сгенерированный массив:");
//         PrintArray(numbers);

//         int evenCount = CountEvenNumbers(numbers);
//         Console.WriteLine($"Количество чётных чисел в массиве: {evenCount}");
//     }

//     // Вывод массива на экран
//     static void PrintArray(int[] arr)
//     {
//         Console.Write("[");
//         for (int i = 0; i < arr.Length; i++)
//         {
//             Console.Write(arr[i]);
//             if (i < arr.Length - 1)
//             {
//                 Console.Write(", ");
//             }
//         }
//         Console.WriteLine("]");
//     }

//     // Подсчет кол-ва чётных чисел в массиве
//     static int CountEvenNumbers(int[] arr)
//     {
//         int count = 0;
//         for (int i = 0; i < arr.Length; i++)
//         {
//             if (arr[i] % 2 == 0)
//             {
//                 count++;
//             }
//         }
//         return count;
//     }
// }


// Задача 36

// using System;

// class Program
// {
//     static void Main()
//     {
//         int[] array = new int[4]; 
//         Random random = new Random();

//         for (int i = 0; i < array.Length; i++)
//         {
//             array[i] = random.Next(-100, 101); 
//         }

//         Console.WriteLine("Сгенерированный массив:");
//         PrintArray(array);

//         int sumOddPositions = CalculateSumOfOddPositions(array);
//         Console.WriteLine($"Сумма элементов на нечётных позициях: {sumOddPositions}");
//     }

//     // Вывод массива на экран
//     static void PrintArray(int[] arr)
//     {
//         Console.Write("[");
//         for (int i = 0; i < arr.Length; i++)
//         {
//             Console.Write(arr[i]);
//             if (i < arr.Length - 1)
//             {
//                 Console.Write(", ");
//             }
//         }
//         Console.WriteLine("]");
//     }

//     // Подсчет суммы элементов на нечётных позициях
//     static int CalculateSumOfOddPositions(int[] arr)
//     {
//         int sum = 0;
//         for (int i = 0; i < arr.Length; i++)
//         {
//             if (i % 2 != 0) // Если индекс нечётный
//             {
//                 sum += arr[i];
//             }
//         }
//         return sum;
//     }
// }


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


// using System;

// class Program
// {
//     static void Main()
//     {
//         double[] array = { 3.22, 4.2, 1.15, 77.15, 65.2 };

//         double max = array[0];
//         double min = array[0];

//         for (int i = 1; i < array.Length; i++)
//         {
//             if (array[i] > max)
//                 max = array[i];

//             if (array[i] < min)
//                 min = array[i];
//         }

//         double difference = max - min;
//         Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");
//     }
// }
// Не знаю корректно ли написано, но ошибок вроде не выдает :) 
// И извините ради бога что так поздно сдаю дз. С работой завал :(
