using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number");



        if (!Int32.TryParse(Console.ReadLine(), out var a))
        {
            Console.WriteLine("NaN. Press Enter to close");
            Console.ReadLine();
            return;
        }

        Console.WriteLine("Enter second number");
        if (!Int32.TryParse(Console.ReadLine(), out var b))
        {
            Console.WriteLine("NaN. Press Enter to close");
            Console.ReadLine();
            return;
        }

        Console.WriteLine("Enter one of the following operators: &, | or ^");
        var s = Console.ReadLine();
        var boolvar = true;
        if (s.Length == 0 && s.Length > 1 && !boolvar)
        // что будет без проверки  && !boolvar
        {
            Console.WriteLine("Wrong expression");
        }

        switch (s[0])
        {
            case '&':
                Console.WriteLine("Result of {0} & {1} = {2}, and {3} in binary, and {4} in hexadecimal", a, b, a & b, Convert.ToString(a & b, 2), Convert.ToString(a & b, 16));
                break;
            case '|':
                Console.WriteLine("Result of {0} | {1} = {2}, and {3} in binary, and {4} in hexadecimal", a, b, a | b, Convert.ToString(a | b, 2), Convert.ToString(a | b, 16));
                break;
            case '^':
                Console.WriteLine("Result of {0} ^ {1} = {2}, and {3} in binary, and {4} in hexadecimal", a, b, a ^ b, Convert.ToString(a ^ b, 2), Convert.ToString(a ^ b, 16));
                break;
            default:
                Console.WriteLine("Wrong expression");
                break;
        }
        Console.ReadLine(); // не понял по какой причине консоль стала сворачиваться после выполнения и не дает посмотреть результат. поправил костылями ридлайн







    }
}