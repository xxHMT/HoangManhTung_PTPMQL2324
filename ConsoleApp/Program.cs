// // See https://aka.ms/new-console-template for more information
// int a = 9;
// int b = 3;
// Console.WriteLine("int {0} + {1} = {2} ", a, b, a + b);

internal class Program
{
    private static void Main(string[] args)
    {
        int a = 10;

        if (a < 0)
        {
            System.Console.WriteLine("{0} la so nguyen am", a);
        }
        else
        {
            if (a % 2 == 0)
            {
                System.Console.WriteLine("{0} la so nguyen duong chan", a);
            }
            else
            {
                System.Console.WriteLine("{0} la so nguyen duong le", a);
            }

        }
    }
}