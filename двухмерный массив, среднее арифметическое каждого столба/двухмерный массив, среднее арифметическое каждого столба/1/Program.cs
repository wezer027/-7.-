int [,] array = new int [3, 4];
double sum = 0;
List<double> avg = new List<double>(array.GetLength(1));

for (int i = 0; i < array.GetLength(0); i++)
{  
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array [i, j] = new Random().Next(0, 100);
        Console.Write($"{array[i, j],3}");    
    }
    Console.WriteLine();    
}
Console.WriteLine();
for (int i = 0; i < array.GetLength(1); i++)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        sum += array [j, i];
    }
    avg.Add(sum / array.GetLength(0));
    Console.Write("{0,6:F2}", avg[i]);
    sum = 0;
}