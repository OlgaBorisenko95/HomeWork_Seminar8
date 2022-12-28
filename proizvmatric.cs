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
int CalcNumber(int[,] matrixA, int[,] matrixB, int strA, int strB)
{
    int mul = 0;
    int sum = 0;
    for (int j = 0; j < matrixB.GetLength(1); j++)
    {
        mul = matrixA[strA, j] * matrixB[j, strB];
        sum = sum + mul;
    }
    return sum;
}
int[,] matrixA = Array(2, 2);
Console.WriteLine();
int[,] matrixB = Array(2, 2);
int a = matrixB.GetLength(1);
int b = matrixA.GetLength(0);
int[,] matrixC = new int[a,b];
if (a != b) Console.WriteLine("Произведение данных матриц невозможно");
else
{   
for (int i=0; i<b; i++)
{
    
    for (int j = 0; j < b; j++)
    {
        matrixC[i,j] = CalcNumber(matrixA, matrixB, i, j );
        
    }
    
}
ExitArray(matrixC);
}
