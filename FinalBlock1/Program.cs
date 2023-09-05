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

string [] CreateUserArray (int count_el)
{
    string [] array = new string [count_el];
    for (int i = 0; i <= count_el - 1; i++)
    {
        Console.WriteLine($"Enter element {i + 1}: ");
        array[i] = Console.ReadLine() ?? String.Empty;
    }
    return array;
}


string [] FinalArray (string [] default_array)
{
    string [] final_array = new string [0];
    for (int i = 0; i < default_array.Length; i++)
    {
        if (default_array[i].Length < 4)
        {
           Array.Resize(ref final_array, final_array.Length + 1);
           final_array[final_array.Length - 1] = default_array[i];
        } 
    }
    return final_array;
}


Console.WriteLine("Enter the length of your array: ");

int user_count_elements = Convert.ToInt32(Console.ReadLine());
string [] array = CreateUserArray(user_count_elements);
string [] result_array = FinalArray(array);

Console.WriteLine($"You array:" + "[" + string.Join(", ", array) + "]");
Console.WriteLine($"Final array: " + "[" + string.Join(", ", result_array) +"]");
