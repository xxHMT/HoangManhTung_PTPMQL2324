// // See https://aka.ms/new-console-template for more information
// int a = 9;
// int b = 3;
// Console.WriteLine("int {0} + {1} = {2} ", a, b, a + b);

internal class Program
{
    private static void Main(string[] args)
    {
        int a, b;

        System.Console.Write("a = ");// Nhap vao a;

        a = Convert.ToInt32(Console.ReadLine()); // Chuyen doi kieu du lieu vua nhap sang int va gan cho a

        System.Console.Write("b = ");

        b = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        System.Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        System.Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        System.Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
        System.Console.WriteLine("{0} % {1} = {2}", a, b, a % b);
    }
}