// программа которая создаёт двухмерный массив, принимает в себя позицию и проверяет есть ли она в массиве 

int [,] array = new int [3, 4];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j],2}");
    }
Console.WriteLine();
}

int a;
int b;
Console.Write("Введите позицию эллемента: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write("Введите позицию эллемента: ");
int.TryParse(Console.ReadLine()!, out b);
if (a <= array.GetLength(0) && b <= array.GetLength(1))
    Console.WriteLine(array[a-1,b-1]);
else
{
    Console.Write("Элемент не найден");
}










// array.GetValue(i); берёт значение по индексу
// array.SetValue (i) присваивает значение
// (new Random().Next(min, max), i) рандом на конкретный индекс
// if (elements.Contains((int)current)) привод curent к int (проверка на уникальность)