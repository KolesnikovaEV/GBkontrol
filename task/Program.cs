// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

string[] array = {"Hello", "2", "Moscow", "London", "yes"};

void Print(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void Symbol(string[] words)
{
    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length <= 3)
        {
            Console.Write($"{words[i]} ");
        }
    }
}

Print(array);
Symbol(array);