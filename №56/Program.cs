int [,] array = new int [4,4];
int [] arrayResult = new int [4];
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

void ArraySum (int [,] newArray, int [] helpArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for(int j = 0; j < newArray.GetLength(1); j++)
        {
            helpArray[i] = helpArray[i] + newArray[i,j];
        }
    }
}
void Arraymin(int [] helparray)
{
    int min = helparray[0];
    int result = 0;
    for(int i = 0; i < helparray.Length; i++)
    {
        if(helparray[i] < min)
        {
            min = helparray[i];
            result = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов : сторока {result+1} ");
}
ArraySum(array, arrayResult);
Arraymin(arrayResult);
