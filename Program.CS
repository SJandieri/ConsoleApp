
//1
//int number, counter = 0;
//Console.WriteLine("sheiyvanet ricxvi: ");
//number = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i <= number; i++)
//{
//    if (number % i == 0)
//    {
//        counter++;
//    }
//}
//if (counter == 2)
//{
//    Console.WriteLine("martivia");
//}
//else
//{
//    Console.WriteLine("shedgenilia");
//}

//2

//int number, counter = 0;

//Console.WriteLine("sheiyvanet ricvxi: ");
//number = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i <= number; i++)
//{
//    if (number % i == 0)
//    {
//        Console.WriteLine("ricxvis gamyopia: {0}", i);
//        counter++;
//    }
//}

//Console.WriteLine("ricxvis gamyopebis raodenoba aris: " + counter);

//3
//int a, sum = 0;
//double average = 0.0;
//Console.WriteLine("sheiyvanet ricxvebis raodenoba: ");
//a = Convert.ToInt32(Console.ReadLine());
//int raodenoba = a;
//while (a != 0)
//{
//    Console.WriteLine("sheiyvane ricxvi: ");
//    int number = Convert.ToInt32(Console.ReadLine());
//    a--;
//    if (number > 0)
//    {
//        sum += number;
//    }
//    average = (sum) / (raodenoba + 0.0);
//}
//Console.WriteLine("aritmetikuli sashualo aris: " + average);
//Console.WriteLine("jami aris: " + sum);


// 5
//bool a = true;
//while (a)
//{
//    int min, max, counter = 1;
//    Console.WriteLine("Enter First number: ");
//    min = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Enter Second number: ");
//    max = Convert.ToInt32(Console.ReadLine());

//    var rnd = new Random();
//    int rndnumber = rnd.Next(min, max);
//    int number;
//    bool b = true;

//    while (b)
//    {

//        Console.WriteLine("Enter Your number:");
//        number = Convert.ToInt32(Console.ReadLine());
//        if (rndnumber != number)
//        {
//            counter++;
//        }
//        if (rndnumber == number)
//        {
//            b = false;
//            Console.WriteLine("gamoicani " + counter + " cdashi");
//            Console.WriteLine("programis chaifiqra: " + rndnumber);
//        }



//    }
//    Console.WriteLine("kidev itamasheb: Yes or No ");
//    string n = Console.ReadLine();
//    if (n == "Yes")
//    {
//        a = true;
//    }
//    else a = false;
//}
//4
int spc, len = 1, count;
Console.WriteLine("Enter Row Number : ");
count = Convert.ToInt32(Console.ReadLine());
spc = count - 1;

for(int i = 1; i <= count; i++)
{
    for(int j=1; j <= spc; j++)
    {
        Console.Write(" ");
    }
    for(int s=1; s<=len; s++)
    { 
        Console.Write("*"); 
    }
    spc--;
    len = len + 2;
    Console.WriteLine();
}

