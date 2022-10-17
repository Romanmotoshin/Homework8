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

int[,] array = NewArray(4,5);

void ArraySort(int[,] arr) {
    int min, temp;
        int length = arr.GetLength(1);
        int height = arr.GetLength(0);
        for (int h = 0; h < height; h++)
        {
            for (int i = 0; i < length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < length; j++)
                {
                    if (arr[h,j] < arr[h,min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    temp = arr[h,i];
                    arr[h,i] = arr[h,min];
                    arr[h,min] = temp;
                }
            }
        }
}


ArraySort(array);


Console.WriteLine("Отсортированный массив");
PrintArray(array);
