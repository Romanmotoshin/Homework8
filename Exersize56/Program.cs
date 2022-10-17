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

int[,] array = NewArray(5,3);

int MinString(int[,] arr) {
    int min = 0, strNumber = 0;
    int length = arr.GetLength(1);
    int height = arr.GetLength(0);

    for(int i = 0; i < length; i++) {
                min += arr[0, i];
    }
        
    for (int h = 0; h < height; h++) {
        int sum = 0;
        for(int i = 0; i < length; i++) {
            sum += arr[h, i];
        }
        if (sum < min) {
            min = sum;
            strNumber = h;
        }
    }  
    return strNumber + 1;     
}


Console.WriteLine("Строка с минимальной суммой значений:" + MinString(array));

