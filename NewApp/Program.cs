using NewApp.Models;

public class Program
{
    private static void Main(string[] args)
    {
        Person ps = new Person();

        string str = "Huynh Cong Hieu";
        int a = 29;
    
        Console.WriteLine("{0} sinh nam {1}",str , ps.GetYearOfBirth(a));

    }
}