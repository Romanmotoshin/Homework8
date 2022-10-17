int GetRandomNumber(int minimum, int maximum)
{
return new Random().Next(minimum, maximum);
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}\t");
        }
        Console.WriteLine();
    }
}


int[,] NewArray(int m, int n) {
    int[,] array = new int[m,n];

    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            array[i, j] = GetRandomNumber(1, 99);
        }
    }
    PrintArray(array);
    return array;
}

int[,] MatrixCompose (int[,] array1, int[,] array2) {
    int[,] answer = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                for (int k = 0; k < array1.GetLength(0); k++)
                {
                    answer[i,j] += array1[i,k] * array2[k,j];
                }
            }
        }
    return answer;
}



Console.WriteLine("Первая матрица:");
int[,] array1 = NewArray(2,2);
Console.WriteLine("Вторая матрица:");
int[,] array2 = NewArray(2,2);
Console.WriteLine("Произведение:");
PrintArray(MatrixCompose(array1, array2));
