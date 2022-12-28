int[,,] Array(int a, int b, int c) 
{
    int[] range = new int[100];
    for (int i = 0; i < 90; i++) range[i] = i + 10; 
    int temp;
    int[,,] array = new int[a, b, c];

    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int k = 0; k < c; k++)
            {
                temp = new Random().Next(0, 90); 
                if (range[temp] > 0)
                {
                    array[i, j, k] = range[temp];
                    range[temp] = -1;
                }
                else k--;
            }
        }
    }
    return array;
}
void ExitArray(int[,,] array) 
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k})    ");
            }
            Console.WriteLine();
        }
    }
}
ExitArray(Array(2, 2, 2));
