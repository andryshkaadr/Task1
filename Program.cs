namespace Task1
{
    using System;
    internal class Program
    {
        /*
        В массиве хранится информация о численности книг в каждом из 35 разделов библиотеки. 
        Выяснить, верно ли, что общее число книг в библиотеке есть шестизначное число
         */
        static void Task23()
        {
            Console.WriteLine("Task23");
            Random r = new Random();
            int arraySize = 35, numberOfBooks = 0;
            string checkingOfNumber;
            int[] array = new int[arraySize];
            Console.WriteLine("Array:");
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = r.Next(100, 40000);
                numberOfBooks += array[i];
                Console.Write($"{array[i]} ");
            }
            checkingOfNumber = (numberOfBooks > 99999 && numberOfBooks < 1000000) ? $"Number of books six-digit number: {numberOfBooks}" : $"Number of books is not a six-digit number: {numberOfBooks}";
            Console.WriteLine($"\n{checkingOfNumber}");
        }


        /*
         Дана последовательность натуральных чисел а1, а2, ..., an. 
        Создать массив из четных чисел этой последовательности. 
        Если таких чисел нет, то вывести сообщение об этом факте.

         */
        static void Task30()
        {
            Console.WriteLine("\nTask30");
            int arraySize1 = 10, arraySize2 = 0;
            bool continueInput = true;
            int[] array1 = new int[arraySize1];

            Console.Write($"Enter {arraySize1} natural numbers: ");
            for (int i = 0; i < arraySize1 && continueInput; i++)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number) && number > 0)
                {
                    array1[i] = number;
                    if (array1[i] % 2 == 0)
                    {
                        arraySize2++;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect value");
                    i--;
                }
            }

            Console.WriteLine("Array 1:");
            for (int i = 0; i < arraySize1; i++)
            {
                Console.Write($"{array1[i]} ");
            }

            if (arraySize2 > 0)
            {
                int[] array2 = new int[arraySize2];
                for (int i = 0, k = 0; i < arraySize2; k++)
                {
                    if (array1[k] % 2 == 0)
                    {
                        array2[i] = array1[k];
                        i++;
                    }
                }
                Console.WriteLine("\nArray 2:");
                for (int i = 0; i < arraySize2; i++)
                {
                    Console.Write($"{array2[i]} ");
                }
            }
            else
            {
                Console.WriteLine("\nNo even numbers");

            }
        }


        /*
        Задана последовательность N вещественных чисел. Вычислить значение выражения .
        Корень N степени из X1*X2*...*Xn 
         */
        static void Task49()
        {
            Console.WriteLine("\n\nTask49");
            int N = 5;
            double[] array = new double[N];
            double summary = 1, result = 0;
            Random r = new Random();
            Console.Write($"\nsqrt^{N}( ");
            for (int i = 0; i < N; i++)
            {
                array[i] = r.NextDouble() * 20 - 10;
                summary = summary * array[i];
                Console.Write($"{array[i]} * ");
            }
            result = Math.Pow(summary, 1 / N);
            Console.Write($") =  {summary}");
        }

        /*
         Дана последовательность вещественных чисел, оканчивающаяся числом 10 000. Количество чисел в последовательности не меньше двух.
        Определить, является ли последовательность упорядоченной по возрастанию. 
        В случае отрицательного ответа определить порядковый номер первого числа, нарушающего такую упорядоченность.
        */
        static void Task86()
        {
            Console.WriteLine("\n\nTask86");
            int arraySize = 10;
            Random r = new Random();
            bool checking = true;
            double[] array = new double[arraySize];
            array[arraySize - 1] = 10000;
            Console.WriteLine("Array :");
            for (int i = 0; i < arraySize - 1; i++)
            {
                array[i] = r.NextDouble() * 100 - 50;
                Console.Write($"{array[i]} ");
            }
            Console.Write($"{array[arraySize - 1]} ");
            for (int i = 1; i < arraySize && checking; i++)
            {
                if (array[i - 1] > array[i])
                {
                    checking = false;
                    Console.WriteLine($"\nElement {i} breaks the ascending sequence");
                }
            }
            if (checking)
            {
                Console.WriteLine("\nSequence increasing");
            }
        }

        /*
         Дан массив целых чисел. Найти в этом массиве минимальный элемент m и максимальный элемент М.
        Получить в порядке возрастания все целые числа из интервала (m; М), которые не входят в данный массив.
        */
        static void Task147()
        {
            Console.WriteLine("\nTask147");
            int min = 100, Max = 0, arraySize = 10;
            int[] array = new int[arraySize];
            Random random = new Random();
            Console.Write("Array: ");
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = random.Next(0, 100);
                Console.Write($"{array[i]} ");
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > Max)
                {
                    Max = array[i];
                }
            }
            Array.Sort(array);
            Console.Write("\nNew array: ");
            for (int i = min, k = 0; i < Max; i++)
            {
                if (k < array.Length && i == array[k])
                {
                    k++;
                }
                else
                {
                    Console.Write($"{i} ");
                }
            }
        }

        static void Main(string[] args)
        {
            Task23();
            Task30();
            Task49();
            Task86();
            Task147();
        }
    }
}