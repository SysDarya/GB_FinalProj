// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

string[] CreateArr(int size)
{
    string[] arr = new string [size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i+1}-й элемент: ");
        string element = Convert.ToString(Console.ReadLine() ?? "0");
        arr[i] = element;
    }
    return arr;
}

void PrintArr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}  ");
    }
    System.Console.WriteLine();
}

string[] CheckArr(string[] arr,int size)
{
    string[] res = new string[size];
    int len = 3;
    int pos = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j].Length <= len)
        {
            res[pos] = arr[j];
            pos++;
        }
    }
    return res;
}

int size = Prompt("Укажите размер массива >>> ");
string[] arrayStr = CreateArr(size);
Console.WriteLine("Ваш массив >>>");
PrintArr(arrayStr);
string[] arrayFin = CheckArr(arrayStr, size);
Console.WriteLine("Обработанный массив >>>");
PrintArr(arrayFin);




