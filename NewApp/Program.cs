using NewApp.Models;

public class Program
{
    private static void Main(string[] args)
    {

        Employee epl = new Employee();

        epl.EnterData();
        epl.Display();

    }
}