﻿class Program {
   static void Main(string[] args)
   {
    int day,time;
    string set;
    int breakfast = 5; int weekend = 2; int coffee = 3;
    Console.Write("Day :");
    day = int.Parse(Console.ReadLine());
    Console.Write("Time :");
    time = int.Parse(Console.ReadLine());

    while (true)
    {
       Console.Write("command :");
       set = Console.ReadLine();

       if (set!= "Breakfast set" && set!= "Weekend set" && set!= "Coffee" && set!= "End")
       {
        Console.WriteLine("What would you like to have?");
        continue;
       }
       if (set == "Breakfast set")
       {
        if (breakfast == 0 || time > 11)
        {
            Console.WriteLine("Unable to purchase this available");
            continue;
        }
        else
        breakfast = breakfast - 1;
       }
       if (set == "coffee")
       {
        if (coffee == 0)
        {
            Console.WriteLine("Unable to purchase this available");
            continue;
        }
        else
        coffee--;
       }
if (set == "Weekend Set")
{
    if((day >= 1 && day <= 5) || weekend == 0)
    {
        Console.WriteLine("Unable to purchase this available");
        continue;
    }
    else
    weekend--;
}
if (set == "End")
{
    break;
}
    }
    Console.ReadLine();

   }

}