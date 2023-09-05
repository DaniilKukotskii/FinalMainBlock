// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

/*
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/



using System.Globalization;

string [] Create_UserArray (int count_el)
{
    string [] array = new string [count_el];
    for (int i = 0; i <= count_el - 1; i++)
    {
        Console.WriteLine("Enter the element: ");
        array[i] = Console.ReadLine();
    }
    return array;
}


string [] FinalArray (string [] defaultarray)
{
    string [] finalarray = new string [0];
    for (int i = 0; i < defaultarray.Length; i++)
    {
        int j = 0;
        if (defaultarray[i].Length < 4)
        {
           Array.Resize(ref finalarray, finalarray.Length + 1);
           finalarray[finalarray.Length - 1] = defaultarray[i];
        } 
    }
    return finalarray;
}


Console.WriteLine("Enter the length of your array: ");

int UserCountElements = Convert.ToInt32(Console.ReadLine());
string [] array = Create_UserArray(UserCountElements);

Console.WriteLine($"You array:" + "[" + string.Join(", ", array) + "]");


string [] ResultArray = FinalArray(array);

Console.WriteLine($"Final array: " + "[" + string.Join(",", ResultArray) +"]");
