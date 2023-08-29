using System.IO.Pipes;
using NewApp.Models;

public class Program
{
    private static void Main(string[] args)
    {
        Kethua kt = new Kethua();

        kt.EnterData();
        kt.Display();


        }
}

