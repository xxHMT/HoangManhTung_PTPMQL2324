using NewApp.Models;

public class Program
{
    private static void Main(string[] args)
    {
        SinhVien sv1 = new SinhVien();

        sv1.FullName = "Gouzze";
        sv1.Address = "Canada";
        sv1.Age = 38;
        sv1.PhoneNumber = 93233345;
    

        sv1.Display();

    }
}