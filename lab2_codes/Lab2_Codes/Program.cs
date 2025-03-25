using Lab2_Codes;

internal class Program
{
    private static void Main(string[] args)
    {
        //Assinment 1 : Hello and Name in Separate Line
        Console.WriteLine("Hello!");
        Console.WriteLine("Surag Basukala");
        Console.ReadKey();

        //Assignment 2: Swapping the numbers
        Console.Clear();
        Console.WriteLine("Swapping \nEnter first number:");
        int input1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int input2 = Convert.ToInt32(Console.ReadLine());
        Swapping swap = new Swapping();
        swap.swapping(input1, input2);
        Console.ReadKey();

        //Assignment 3: Largest among three numbers
        Console.Clear();
        Console.WriteLine("Largest Number among three numbers");
        Comparision compare = new Comparision();
        compare.largest(4, 1, 9);
        Console.ReadKey();

        //Assignment 4: Checking the number is even or odd
        Console.Clear();
        Console.WriteLine("Check OddEven");
        OddEven checknum = new OddEven();
        bool result = checknum.checkOddEven();
        if(result)
        {
            Console.WriteLine("The entered number is even.");
        }
        else
        {
            Console.WriteLine("The entered number is odd.");
        }
        Console.ReadKey();

        //Assignment 5 : Sum of n natural numbers
        Console.Clear();
        Console.WriteLine("Sum of Natural Numbers");
        SumOfNaturalNumbers sum = new SumOfNaturalNumbers();
        sum.naturalNumberSum();
        Console.ReadKey();

        //Assignment 6: Checking whether the year is leap year or not.
        Console.Clear();
        Console.WriteLine("Checking whether the year is leap or not");
        IsLeapYear check = new IsLeapYear();
        check.isLeapYear();
        Console.ReadKey();

        //Assignment 7 : Array and sum of its elements
        Console.Clear();
        Console.WriteLine("Sum of the items in the array");
        SumofArrayElements arrayelemetsum = new SumofArrayElements();
        arrayelemetsum.sumOfArrayElements();
        Console.ReadKey();

        //Assignment 8 : Factorial of the Number
        Console.Clear();
        Console.WriteLine("Factorial");
        Factorial fact = new Factorial();
        fact.calcFactorial();
        Console.ReadKey();

        //Assignment 9 : Checking whether the number is prime or not.
        Console.Clear();
        Console.WriteLine("Prime Number or not");
        PrimeNumber isPrime = new PrimeNumber();
        isPrime.checkPrimeNumber();
        Console.ReadKey();
    }
}