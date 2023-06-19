using System;

class Program
{
    static void Main()
    {
        string[] array = ReadArrayFromInput();
       
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
}

