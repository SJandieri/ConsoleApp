string[] input = Console.ReadLine().Trim().Split();
int[] array = new int[input.Length];

for (int i = 0; i < input.Length; i++)
{
    array[i] = int.Parse(input[i]);
}

int maxLength = 1;
int currentLength = 1;
int endIndex = 0;

for (int i = 1; i < array.Length; i++)
{
    if (array[i] > array[i - 1])
    {
        currentLength++;

        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            endIndex = i;
        }
    }
    else
    {
        currentLength = 1;
    }
}


for (int i = endIndex - maxLength + 1; i <= endIndex; i++)
{
    Console.Write(array[i] + " ");
}
