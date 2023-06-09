int A;
Console.WriteLine("sheuyvane pirveli masivis raodenoba: ");
A = Convert.ToInt32(Console.ReadLine());
int[] first = new int[A];

for (int i = 0; i < A; i++)
{
    Console.WriteLine("sheiyavne ricxvi: ");
    var inp = Convert.ToInt32(Console.ReadLine());
    first[i] = inp;

}
int B;
Console.WriteLine("sheuyvane meore masivis raodenoba: ");
B = Convert.ToInt32(Console.ReadLine());
int[] Second = new int[B];

for (int i = 0; i < B; i++)
{
    Console.WriteLine("sheiyavne ricxvi: ");
    var inp = Convert.ToInt32(Console.ReadLine());
    Second[i] = inp;

}
int[] AB = new int[A + B];
for (int i = 0; i < A; i++)
{
    AB[i] = first[i];

}
for (int i = 0; i < B; i++)
{
    AB[A + i] = Second[i];

}
for (int i = 0; i < A + B; i++)
{
    Array.Sort(AB);
    Console.Write(AB[i] + " ");


}
