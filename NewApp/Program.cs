using System.IO.Pipes;
using NewApp.Models;

public class Program
{
    private static void Main(string[] args)
    {
        Fruit fruit = new Fruit();

        fruit.EnterData();
        fruit.Display();


        }
}

