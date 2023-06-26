// Написать программу,
// которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.



string[] GetArrayString(string inConsolSimvol)
{
    string[] arraySimvol = new string[inConsolSimvol.Length];
    arraySimvol = inConsolSimvol.Split(",");
    return arraySimvol;
}

string[] TextArrayFormation(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string simvol = array[i];
        if (simvol.Length <= 3)
        {
            count += 1;
        }
    }
    string[] arrayThreeSimvol = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        string simvol = array[i];
        if (simvol.Length <= 3)
        {
            arrayThreeSimvol[j] = simvol;
            j++;
        }
    }
    return arrayThreeSimvol;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

Console.Write("Введите элементы массива через знак (,) - ");
string inStringSimvol = Console.ReadLine();
string[] arraySimvol = GetArrayString(inStringSimvol);
Console.WriteLine();
Console.Write("Введенные элементы - ");
PrintArray(arraySimvol);
Console.WriteLine();
Console.Write("Введенные элементы длинной меньше либо равные 3 - ");
PrintArray(TextArrayFormation(arraySimvol));
Console.WriteLine();
