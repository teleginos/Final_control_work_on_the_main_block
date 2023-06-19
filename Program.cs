using System;

class Program
{
    static void Main()
    {
        string[] array = ReadArrayFromInput();
        string[] newArray = FilterArrayByLength(array, 3);
    }

    static string[] ReadArrayFromInput()
    {
        Console.WriteLine("Введите количество элементов массива: ");
        int size = int.Parse(Console.ReadLine());

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
}

