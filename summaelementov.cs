int[,] Array(int a, int b) 
{
    int[,] array = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write($"{array[i, j]}    ");
        }
        Console.WriteLine();
    }
    return array;
}
int SumInLines(int[,] array)
{
    int minSum = 0;
    int minSumLine = 0;
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (i == 0) minSum = sum;
        if (minSum >= sum)
        {
            minSum = sum;
            minSumLine = i + 1;
        }
        sum = 0;
    }
    return minSumLine;
}
int EnterData(string text) 
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int a = EnterData("Введите количество строк массива: ");
int b = EnterData("Введите количество столбцов массива: ");
int[,] array = Array(a, b);
int result = SumInLines(array);
Console.WriteLine("Минимальная сумма значений в строке № " + result);
