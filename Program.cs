using System;

class Program
{
    static void Main()
    {
        string[] array = ReadArrayFromInput();
        string[] newArray = FilterArrayByLength(array, 3);
        Console.WriteLine($"Результат работы программы:\n[{String.Join(",", array)}] -> [{String.Join(",", newArray)}]");

    }

    static string[] ReadArrayFromInput()
    {
        
        int size = DigitСheck();

        string[] array = new string[size];
        Console.WriteLine("Введите элементы массива (каждый с новой строки): ");
        for (int i = 0; i < size; i++)
        {
            array[i] = Console.ReadLine();
        }

        return array;
    }

    static string[] FilterArrayByLength(string[] array, int maxLength)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= maxLength)
            {
                count++;
            }
        }

        string[] newArray = new string[count];
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= maxLength)
            {
                newArray[index] = array[i];
                index++;
            }
        }
        
        return newArray;
    }
    static int DigitСheck()
    {   
        int num;
        Console.WriteLine("\nВведите количество элементов массива: ");
        string symbol = Console.ReadLine();
        if (int.TryParse(symbol, out num) && int.Parse(symbol) > 0)
        {
            return num;
        }else
        {
            Console.WriteLine("Не правильнно указано значение (Для ввода доступны только положительные числа!)\n");
            return DigitСheck();
        }
    }
}

