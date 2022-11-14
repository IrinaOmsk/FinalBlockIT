Console.WriteLine("Задайте массив строк через пробел: ");


string[] inputArray = Console.ReadLine().Split(' ');
int N = inputArray.Length;
string[] outputArray = new string[inputArray.Length];

void CreatNewArray(string[] inputArray, string[] outputArray)
{
    int i = 0;
    int j = 0;

    while (i < N)
    {
        if (inputArray[i].Length <= 3)
        {
            outputArray[j] = inputArray[i];
            j++;
        }
        i++;
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

CreatNewArray(inputArray, outputArray);
PrintArray(outputArray);
