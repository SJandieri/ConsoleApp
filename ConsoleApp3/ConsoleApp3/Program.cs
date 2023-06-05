using System;
using System.ComponentModel;


while (true)
    {
    string b = Console.ReadLine();
    int c = Convert.ToInt32(b);
    int z = c % 12;
    switch (z)
    {
        case 0:
            Console.WriteLine("Monkey");
            break;
        case 1:
            Console.WriteLine("Rooster");
            break;
        case 2:
            Console.WriteLine("Dog");
            break;
        case 3:
            Console.WriteLine("Pig");
            break;
        case 4:
            Console.WriteLine("Rat");
            break;
        case 5:
            Console.WriteLine("Ox");
            break;
        case 6:
            Console.WriteLine("Tiger");
            break;
        case 7:
            Console.WriteLine("Rabbit");
            break;
        case 8:
            Console.WriteLine("Dragon");
            break;
        case 9:
            Console.WriteLine("Snake");
            break;
        case 10:
            Console.WriteLine("Horse");
            break;
        case 11:
            Console.WriteLine("Sheep");
            break;
        
    }

//Console.WriteLine("Temperature(°C)");
//string a = Console.ReadLine();
//    int b = Convert.ToInt32(a);


//if (b <= 0) Console.WriteLine("Freez");
//else if (b > 0 && b < 30) Console.WriteLine("Good Weather");
//else if (b > 30) Console.WriteLine("Hot");

//    Console.WriteLine("Rock,Paper,Scissors");
//    string a = Console.ReadLine();
//    var rnd = new Random();
//    int randomNum = rnd.Next(1,4);

//    int b =0;
//    if(a == "Rock") b = 1;
//    else if (a == "Paper") b = 2;
//    else if (a == "Scissors") b = 3;

//    switch(randomNum)
//    {
//        case 1:

//            if (b == 1) Console.WriteLine("Draw");
//            else if (b == 2) Console.WriteLine("Win");
//            else if (b == 3) Console.WriteLine("Loose");
//            break;
//        case 2:

//            if (b == 1) Console.WriteLine("Loose");
//            else if (b == 2) Console.WriteLine("Draw");
//            else if (b == 3) Console.WriteLine("Win");
//            break;
//        case 3:

//            if (b == 1) Console.WriteLine("Win");
//            else if (b == 2) Console.WriteLine("Loose");
//            else if (b == 3) Console.WriteLine("Draw");
//            break;

//    }
}


