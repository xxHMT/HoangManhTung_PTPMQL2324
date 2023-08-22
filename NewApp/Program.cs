using NewApp.Models;

public class Program
{
    private static void Main(string[] args)
    {
        Person ps1 = new Person();
        Person ps2 = new Person();

        ps1.FullName = "Hoang Van D";
        ps1.Address = "Phu Tho";
        ps1.Age = 35;

        ps2.FullName = "Nguyen Thao M";
        ps2.Address = "Ha Noi";
        ps2.Age = 18;

    

        ps1.Display();
        ps2.Display();

    }
}