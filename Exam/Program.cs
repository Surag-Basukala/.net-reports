using Exam;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Checking the Palindrome");
        Console.WriteLine("Enter the number to check palindrome");

        int number = Convert.ToInt32(Console.ReadLine());

        Palindrome palindromecheck = new Palindrome();
        string result = palindromecheck.checkPalindrome(number);
        Console.WriteLine(result);

        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Checking the character is Capital,Small,Number or Special Character");
        Console.WriteLine("Enter the character");
        char ch = Convert.ToChar(Console.ReadLine());

        CheckLetter checkLetter = new CheckLetter();
        string result1 = checkLetter.checkLetter(ch);
        Console.WriteLine(result1);

        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Example of Polymorphism (function overloading)");
        Console.WriteLine("Enter the value of a,b and c");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        Polymorphism calc = new Polymorphism();
        int result3 = calc.Add(a, b);
        int result4 = calc.Add(a, b, c);
        Console.WriteLine(result3);
        Console.WriteLine(result4);

        Console.ReadKey(); 
        Console.Clear();

        Console.WriteLine("Multiple Inheritance");
        DerivedClass deriveClass = new DerivedClass();
        deriveClass.Cat();
        deriveClass.Dog();


    }
}