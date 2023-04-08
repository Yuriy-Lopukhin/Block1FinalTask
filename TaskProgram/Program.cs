//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. 
/////////////////////////////////////////////////////////////////////////////////////////////////
int M = InputNumber("Введите длину массива: ");
string[] array = GetStringArray(M);
string[] resultArray = GetResult(array);
PrintArray(array);
Console.WriteLine();
PrintArray(resultArray);
/////////////////////////////////////////////////////////////////////////////////////////////////
// ОПИСАНИЕ МЕТОДОВ:
/////////////////////////////////////////////////////////////////////////////////////////////////
//Ввод длины массива.
static int InputNumber(string message)
{
    try
    {
        Console.Write(message);
        return (int.Parse(Console.ReadLine() ?? "")); 
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return 0; 
    }
}

//Ввод строковых значений массива 
static string InputString(string message)
{
        Console.Write(message);
        string value = Console.ReadLine() ?? "";
        return value; 
}

//Создание и заполнение строкового массива
string[] GetStringArray(int size)
{
    string[] res = new string[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = InputString($"Введите {i+1} строку массива: ");
    }
    return res;
}

//Создание второго массива с выборкой данных. 
string[] GetResult(string[] inArray)
{
    string[] res = new string[inArray.Length];
    int count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length <= 3) res[count] = inArray[i];
        count++;
    }
    return res;
}
//Вывод массива на экран
void PrintArray(string[] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    { 
            Console.Write($"{inArray[i]} ");
    }
}
