// Date: sept 15 2020
using System;

class Assignment
{
    static void Main()

    {
        Assignment assignment = new Assignment();

        Console.WriteLine("Enter first number");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number");
        int num2 = Convert.ToInt32(Console.ReadLine());

        bool sc = assignment.sumChecker(num1, num2);
        Console.WriteLine(sc ? "Sum is greater than 500" : "Sum is less than 500");

        Console.WriteLine("Enter number of wins");
        int wins = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number of draws");
        int draws = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number of losses");
        int losses = Convert.ToInt32(Console.ReadLine());

        int points = assignment.teamPointsCalc(wins, draws, losses);
        Console.WriteLine("Total Score is: " + points);


        Console.WriteLine("Enter two words separated by space");
        string str = Console.ReadLine();
        string initials = assignment.getInitials(str);
        Console.WriteLine(initials);







    }

    bool sumChecker(int num1, int num2) => num1 + num2 > 500 ? true : false;


    int teamPointsCalc(int wins, int draws, int losses) => wins * 5 + draws * 2;


    string getInitials(String input)
    {
        string[] strs = input.Split(" ");
        string initials = "";
        if (strs.Length != 2)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid String");
            Console.ResetColor();
            return "";


        }
        foreach (string s in strs)
        {
            initials = initials + s[0];
        }
        return initials;
    }

}
