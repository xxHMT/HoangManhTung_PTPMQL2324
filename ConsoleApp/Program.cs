// // See https://aka.ms/new-console-template for more information
// int a = 9;
// int b = 3;
// Console.WriteLine("int {0} + {1} = {2} ", a, b, a + b);

internal class Program
{
    private static void Main(string[] args)
    {
        string str = "666";
        // CHUYEN DOI KIEU DU LIEU SU DUNG LOP CONVERT

        int x = Convert.ToInt32(str);
        System.Console.WriteLine("x = " + x);

    }
}