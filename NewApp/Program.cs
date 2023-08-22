using NewApp.Models;

public class Program
{
    private static void Main(string[] args)
    {
        GiaiPT gpt = new GiaiPT();

        gpt.a = 2;
        gpt.b = 1;

        gpt.GiaiPTB1();
    }
}