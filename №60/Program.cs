int [,,] array = new int [2,2,2];

void FullArray (int [,,] newArray)
{
     for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            for (int k = 0; k < newArray.GetLength(2); k++)
            {
                newArray[i, j, k] = new Random().Next(10,100);
            } 
        }
    }
}
void PrintArray(int [,,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
    
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            for(int k = 0; k < newArray.GetLength(2); k++)
            {
                Console.Write($"{newArray[i, j, k]}({i}{j}{k}) ");
            }
        }
        Console.WriteLine();
    }
} 
FullArray (array);
PrintArray (array);