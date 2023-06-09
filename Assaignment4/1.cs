int N;
Console.WriteLine("enter array item number: ");
N = Convert.ToInt32(Console.ReadLine());
int[] naturalnumber = new int[N];

for (int i = 0; i < N; i++)
{
    Console.WriteLine("enter number: ");
    var input = Console.ReadLine();
    naturalnumber[i] = Convert.ToInt32(input);
}
int a = 0;
for (int j = 0; j < naturalnumber.Length; j++)
{
    for (int n = j + 1; n < naturalnumber.Length; n++)
    {
        if (naturalnumber[j] > naturalnumber[n])
        {
            a = naturalnumber[n];
            naturalnumber[n] = naturalnumber[j];
            naturalnumber[j] = a;



        }
    }
    Console.Write(naturalnumber[j] + " ");

}
