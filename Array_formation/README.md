
 # Решение задачи
 
## 1. Создание метода string[] GetArrayString

* создаем метод для разделения введенной пользователем строки в массив по знаку “,”.
```
string[] GetArrayString (string inConsolSimvol)
{
    string[] arraySimvol = new string[inConsolSimvol.Length];
    arraySimvol = inConsolSimvol.Split(",");
    return arraySimvol;
}
```

## 2. Создание метода string[] TextArrayFormation

* создаем метод сортирующий символы из массива. Сначала отсчитываем количество, удовлетворяющих требованию для определения длинны нового массива. Создаем массив по подсчитанному количествуи и заносим символы удовлетворяющие требованиям.
```
string[] TextArrayFormation (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string simvol = array[i];
        if (simvol.Length <= 3)
        {
            count++;
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
```

## 3. Создание метода void PrintArray

* создаем метод для вывода информации из массивов с использованием цеклического вывода каждого элемента массива.
```
void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}
```

## 4. Создаем "клентский код" для вызова методов и обработки информации через консоль.

* выводим поясняющую информационную строку для пользователя в консоли: "Введите набор символов через знак (,)"

* присваиваем введенные в консоли от пользователя элементы string inStringSimvol = console.ReadLine()
* присваиваем массиву преобразованную строку через метод string[] arraySimvol = GetArrayString(inStringSimvol)

```
Console.Write("Введите элементы массива через знак (,) - ");
string inStringSimvol = Console.ReadLine();
TextArrayFormationstring[] arraySimvol = GetArrayString(inStringSimvol);
Console.WriteLine();
Console.Write("Введенные элементы - ");
PrintArray(arraySimvol);
Console.WriteLine();
Console.Write("Введенные элементы длинной меньше либо равные 3 - ");
PrintArray(TextArrayFormation(arraySimvol));
Console.WriteLine();
```

