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
int[,] ArraySort(int[,] array) 
{
    int temp;
    for (int lineNumber = 0; lineNumber < array.GetLength(0); lineNumber++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[lineNumber, j] < array[lineNumber, j + 1])
                {
                    temp = array[lineNumber, j];
                    array[lineNumber, j] = array[lineNumber, j + 1];
                    array[lineNumber, j + 1] = temp;
                }
            }
        }
    }
    return array;
}
int EnterData(string text) 
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
void ExitArray(int[,] array) 
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}    ");
        }
        Console.WriteLine();
    }
}
int a = EnterData("Введите количество строк массива: ");
int b = EnterData("Введите количество столбцов массива: ");
int[,] array = Array(a, b);
array = ArraySort(array);
ExitArray(array);