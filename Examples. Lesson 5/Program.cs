// Console.Clear();
// Console.WriteLine("Введите числа через пробел");

// string input = Console.ReadLine()!;
// int[] array = ParseToArray(input);

// Console.Write($"Положительная сумма: {PositiveSum(array)}");
// Console.Write($"Отрицательная сумма: {NegativeSum(array)}");



// int[] ParseToArray(string str)
// {
//     string[] stringArray = str.Split(" ");
//     int[] result = new int[stringArray.Length];

//     for (int i = 0; i < stringArray.Length; i++)
//     {
//         result[i] = int.Parse(stringArray[i]);
//     }

//     return result;
// }

// int PositiveSum(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//             count += array[i];
//     }

//     return count;
// }
// int NegativeSum(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0)
//             count += array[i];
//     }

//     return count;
// }


// Задача 35: Напишите метод, который суммирует 2 массива. Каждый элемент одного массива должен суммироваться с соответствующим элементом из второго массива. Если длины массивов не равны, то должно появляться сообщение об ошибке

// [5, 18, 123, 6, 2] + [1, 2, 3, 6, 2] = [6, 20, 126, 12, 4]

// int[] StringToArray(string str)
// {
//     string[] stringArray = str.Split(" ");
//     int[] result = new int[stringArray.Length];

//     for (int i = 0; i < stringArray.Length; i++)
//     {
//         result[i] = int.Parse(stringArray[i]);
//     }
//     return result;
// }

// int[] SumArray(int[] arrOne, int[] arrTwo)
// {
//     int[] resArray = new int[arrOne.Length];
//     for (int i = 0; i < arrOne.Length; i++)
//     {
//         resArray[i] = arrOne[i] + arrTwo[i];
//     }

//     return resArray;
// }


// void PrintArray(int[] array)
// {
//     int lengthArray = array.Length;

//     Console.Write("[ ");
//     for (int i = 0; i < lengthArray; i++)
//     {
//         Console.Write(array[i]);
//         if (i < lengthArray - 1) Console.Write(" , ");
//     }
//     Console.Write(" ]");
// }


// Console.Clear();
// Console.WriteLine("введите числа первого массива через пробел");


// string inputOne = Console.ReadLine();
// int[] arrayOne = StringToArray(inputOne);
// string inputTwo = Console.ReadLine();
// int[] arrayTwo = StringToArray(inputTwo);
// int[] arrayThree = new int[arrayOne.Length];

// if (arrayOne.Length != arrayTwo.Length)
// {
//     Console.WriteLine("длины массивов не совпадают");
// }
// else
// {
//     arrayThree = SumArray(arrayOne, arrayTwo);
//     PrintArray(arrayThree);
// }


// Вариант 2 решения задачи:

// int[] ParseToArray(string str)

// {
//     string[] stringArray = str.Split(" "); 
//     int[] result = new int[stringArray.Length];

//     for (int i = 0; i < stringArray.Length; i++)
//     {
//         result[i] = int.Parse(stringArray[i]);
//     }

//     return result;
// }

// int[] SumOfArray(int[] firstArray, int[] secondArray)
// {
//     int[] result = new int [firstArray.Length];
//     for (int i = 0; i < firstArray.Length; i++)
//     {
//         result[i] = firstArray[i] + secondArray[i];
//     }

//     return result;
// }

// Console.Write("Введите числа первого массива через пробел: ");
// string firstArray = Console.ReadLine()!;

// Console.Write("Введите числа второго массива через пробел: ");
// string secondArray = Console.ReadLine()!;

// int[] fArray = ParseToArray(firstArray);
// int[] sArray = ParseToArray(secondArray);

// if(fArray.Length != sArray.Length)
// {
//     Console.Write("Массивы неравноразмерны!!!!11!");
// }
// else
// {
//     int[] res = SumOfArray(fArray, sArray);
//     Console.Write(String.Join(", ", res));
// }


// Задача 37: Напишите метод, который объединяет 2 массива в 1. [5, 18, 123, 6, 2] + [1, 2, 3] = [5, 18, 123, 6, 2, 1, 2, 3]

// int[] StringToArray(string str)
// {
//     string[] stringArray = str.Split(" ");
//     int[] result = new int[stringArray.Length];

//     for (int i = 0; i < stringArray.Length; i++)
//     {
//         result[i] = int.Parse(stringArray[i]);
//     }
//     return result;
// }

// int[] NewArray(int[] arrOne, int[] arrTwo)
// {
//     int[] arrayRes = new int[arrOne.Length + arrTwo.Length];
//     for (int i = 0; i < arrOne.Length; i++)
//     {
//         arrayRes[i] = arrOne[i];
//     }
//     for (int i = arrOne.Length; i < (arrOne.Length + arrTwo.Length); i++)
//     {
//         arrayRes[i] = arrTwo[i - arrOne.Length];
//     }

//     return arrayRes;

// }

// void PrintArray(int[] array)
// {
//     int lengthArray = array.Length;

//     Console.Write("[ ");
//     for (int i = 0; i < lengthArray; i++)
//     {
//         Console.Write(array[i]);
//         if (i < lengthArray - 1) Console.Write(" , ");
//     }
//     Console.Write(" ]");
// }


// Console.Clear();
// Console.WriteLine("введите числа первого массива через пробел");

// string inputOne = Console.ReadLine();
// int[] arrayOne = StringToArray(inputOne);


// Console.WriteLine("введите числа второго массива через пробел");

// string inputTwo = Console.ReadLine();
// int[] arrayTwo = StringToArray(inputTwo);

// int[] arrayThree = new int[arrayOne.Length + arrayTwo.Length];

// arrayThree = NewArray(arrayOne, arrayTwo);
// PrintArray(arrayThree);


// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.) [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]

// int[] StringToArray(string str)
// {
//     string[] stringArray = str.Split(" ");
//     int[] result = new int[stringArray.Length];

//     for (int i = 0; i < stringArray.Length; i++)
//     {
//         result[i] = int.Parse(stringArray[i]);
//     }
//     return result;
// }

// int[] InvertArray(int[] array)
// {
//     int a = 0;

//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         a = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = a;
//     }

//     return array;
// }

// void PrintArray(int[] array)
// {
//     int lengthArray = array.Length;

//     Console.Write("[ ");
//     for (int i = 0; i < lengthArray; i++)
//     {
//         Console.Write(array[i]);
//         if (i < lengthArray - 1) Console.Write(" , ");
//     }
//     Console.Write(" ]");
// }

// Console.Clear();
// Console.WriteLine("введите числа  массива через пробел");

// string inputOne = Console.ReadLine();
// int[] arrayOne = StringToArray(inputOne);

// arrayOne = InvertArray(arrayOne);
// PrintArray(arrayOne);
