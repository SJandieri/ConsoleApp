int[] Array = new int[] { 5, 40, 77, 63, 100 };
int Ind = 4;

Console.WriteLine(SumOfNumber(Array, Ind));

int SumOfNumber(int[] Array, int Ind)
{
    int sum = 0, m, item;

    item = Array[Ind];

    while (item != 0)
    {
        m = item % 10;
        sum += m;
        item = item / 10;
    }
    return sum;
}
