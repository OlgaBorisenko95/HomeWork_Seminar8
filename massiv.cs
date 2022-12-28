int[,] Array(int a, int b) 
{
    int iStart = 0, iEend = 0, jStart = 0, jEnd = 0;
    int c = 1, i = 0, j = 0;
    int[,] array = new int[a, b];
    while (c <= a * b)
    {
        if (i == iStart && j < b - jEnd - 1)
        {
            array[i, j] = c;
            j++;
        }
        else
        {
            if (j == b - jEnd - 1 && i < a - iStart - 1)
            {
                array[i, j] = c;
                i++;
            }
            else
            {
                if (i == a - iStart - 1 && j > jEnd)
                {
                    array[i, j] = c;
                    j--;
                }
                else
                {
                    array[i, j] = c;
                    i--;
                }
            }
        }
        if ((i == iStart + 1) && (j == jStart) && (jStart != b - jStart - 1))
        {
            iStart++;
            iEend++;
            jStart++;
            jEnd++;
        }
        c++;
    }
    return array;
}
void ExitArray(int[,] array) // Вывод двумерного массива
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j]<10) Console.Write($"0{array[i, j]}    ");
            else Console.Write($"{array[i, j]}    ");
        }
        Console.WriteLine();
    }  
}
int a = 4, b = 4;
ExitArray(Array(a, b));
