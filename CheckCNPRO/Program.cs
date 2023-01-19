using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("CNP Checker for Romanian citizens");
        Console.Write("Enter CNP: ");
        string cnp = Console.ReadLine();

        if (cnp.Length != 13)
        {
            Console.WriteLine("Invalid CNP. Must be 13 digits.");
            return;
        }

        int[] weights = { 2, 7, 9, 1, 4, 6, 3, 5, 8, 2, 7, 9 };
        int sum = 0;

        for (int i = 0; i < 12; i++)
        {
            sum += weights[i] * int.Parse(cnp[i].ToString());
        }

        int controlDigit = sum % 11;
        if (controlDigit == 10) controlDigit = 1;
        int lastDigit = int.Parse(cnp[12].ToString());

        if (controlDigit == lastDigit)
        {
            Console.WriteLine("Valid CNP.");
        }
        else
        {
            Console.WriteLine("Invalid CNP.");
        }
    }
}
