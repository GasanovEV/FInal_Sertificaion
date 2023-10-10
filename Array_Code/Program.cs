using System;

class Program
{
    static void Main(string[] args)
    {
        // Вводим исходный массив с клавиатуры
        Console.WriteLine("Введите элементы массива (каждый элемент с новой строки, для окончания введите пустую строку):");

        string[] inputArray = new string[100]; // Максимальный размер массива
        int n = 0; // Текущий размер массива

        string input = Console.ReadLine();

        while (!string.IsNullOrEmpty(input))
        {
            inputArray[n] = input;
            n++;
            input = Console.ReadLine();
        }

        // Создаем новый массив для строк, длина которых <= 3 символам
        string[] newArray = new string[100]; // Максимальный размер массива
        int m = 0; // Текущий размер массива

        for (int i = 0; i < n; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                newArray[m] = inputArray[i];
                m++;
            }
        }

        // Выводим новый массив
        Console.WriteLine("Результат:");

        for (int i = 0; i < m; i++)
        {
            Console.WriteLine(newArray[i]);
        }
    }
}


