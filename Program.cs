// 1. 
int[,] CreateRandomArray(int m, int n, int min, int max)
{
    int[,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j= 0; i < m; j++)
    {
        array[i,j] = new Random().Next(min, max + 1);
    }
    return array;
    }
}
void ShowArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
    }
}
int[,] myArray = CreateRandomArray(3, 4, -9, 10);
ShowArray(myArray);
