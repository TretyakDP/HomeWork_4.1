using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер массива (больше 2): ");
        if (int.TryParse(Console.ReadLine(), out int arraySize) && arraySize > 2)
        {
            int[] array = new int[arraySize];

            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите элемент {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int element))
                {
                    array[i] = element;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                    i--;
                }
            }

            int sum = 0;
            foreach (int element in array)
            {
                sum += element;
            }

            Console.WriteLine($"Сумма всех элементов: {sum}");
        }
        else
        {
            Console.WriteLine("Некорректный размер массива. Введите число больше 2.");
        }
    }
}