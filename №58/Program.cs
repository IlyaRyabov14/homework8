int [,] matrix1 = new int [4,4]; 
int [,] matrix2 = new int [4,4]; 
int [,] result = new int [4,4];
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
FullArray(matrix1);
PrintArray(matrix1);
Console.WriteLine();
FullArray(matrix2);
PrintArray(matrix2);

void multiplication(int [,] helpArray, int [,] array1, int [,] array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            for (int l = 0; l < array2.GetLength(0); l++)
            {
                for (int k = 0; k < array2.GetLength(1); k++)
                {
                    helpArray[i,j] = array1[i,j] * array2[l,k];
                }
            }
        }
    }
}
Console.WriteLine();
multiplication(result, matrix1, matrix2);
PrintArray(result);