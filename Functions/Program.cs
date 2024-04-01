
using System;
class Program
{
    //Function with no Parameter and no Return Value
    static void DisplayMessage()
    {
        Console.WriteLine("This is a Message!");
    }

    //Function with Parameter but no Return Value

    static void GreetPerson(string name)
    {
        Console.WriteLine("Hello " + name);
    }

    //Function with no Parameter but Return Value

    static int GetCurrentYear()
    {
        return DateTime.Now.Year;
    }

    //Using Parameter and Return Type

    static int AddNumbers(int a, int b)
    {
        return a + b;
    }

    //Pass by Value

    static void IncrementNumber(int x)
    {
        x++;
        Console.WriteLine($"Inside Method in Pass by Value: {x}");
    }

    //Pass by Reference

    static void IncrementNum(ref int x)
    {
        x++;
        Console.WriteLine($"Outside Method in Pass by Reference: {x}");
    }

    //enum
    public enum DaysOfWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

    //struct

    public struct Point
    {
        public int x;
        public int y; 
    }

    //******************************************************************************************************************

    //Main

    static void Main()
    {
        DisplayMessage();

        GreetPerson("Neethu");

        int currentYear = GetCurrentYear();
        Console.WriteLine($"The Current Year is: {currentYear}");

        int sum = AddNumbers(5, 3);
        Console.WriteLine($"Sum is: {sum}");

        int number = 5;
        IncrementNumber(number);
        Console.WriteLine($"Outside Method in Pass by Value: {number}");

        int num = 5;
        IncrementNum(ref num);
        Console.WriteLine($"Outside Method in Pass by Reference: {num}");

        //COLLECTIONS

        //Array

        int[] numbers = [1, 2, 3, 4, 5];
        foreach (int number3 in numbers)
        {
            Console.WriteLine(number3);
        }

        //List

        //List<int> numbersList = new List<int> { 1, 2, 3, 4, 5 };

        List<string> namesList = new List<string> { "Alice", "Bob", "James" };
        foreach (string name in namesList)
        {
            Console.WriteLine(name);
        }

        //Dictionary(Dict)
        Dictionary<string, int> ageDictionary = new Dictionary<string, int>
        {
            {"Alice", 25 },
            {"Bob", 38 },
            {"James", 45 }
        };
        foreach (var pair in ageDictionary)
        {
            Console.WriteLine($"{pair.Key} : {pair.Value} years old");
            Console.WriteLine(pair);
        }

        //HashSet

        HashSet<string> uniqueNames = new HashSet<string> { "Alice", "Bob", "James", "Alice" };
        foreach (string uniqueName in uniqueNames)
        {
            Console.WriteLine(uniqueName);
        }

        //enum

        DaysOfWeek today = DaysOfWeek.Wednesday;
        Console.WriteLine($"Today is: {today}");
        
        //struct

        Point myPoint = new Point { x=10, y=20};
        Console.WriteLine($"X:{myPoint.x}, Y:{myPoint.y}");

        //Multi Dimentional Array


    }
}