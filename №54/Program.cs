int [,] array = new int [3,4];

void FullArray (int [,] newArray)
{
     for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int [,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
    
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            Console.Write(newArray[i, j] + " ");
        }
        Console.WriteLine();
    }
} 
FullArray (array);
PrintArray (array);

void SortArray (int [,] newArray)
{
    for(int i = 0; i < newArray.GetLength(0); i++)
    {
        for(int j = 0; j < newArray.GetLength(1); j++)
        {
           for (int k = 0; k < array.GetLength(1) -1 ; k++)
            {
                if (array [i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}
SortArray(array);
Console.WriteLine();
PrintArray (array);
