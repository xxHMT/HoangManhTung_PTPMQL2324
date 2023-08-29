using System.IO.Pipes;
using NewApp.Models;

public class Program
{
    private static void Main(string[] args)
    {
        //Khai bao mang 
        int n = 0;

        do
        {
            System.Console.WriteLine("Nhap vao n:");
            n = Convert.ToInt32(Console.ReadLine());
        } while (n < 1);

        SinhVien [] svArr = new SinhVien[n];
        for(int i = 0; i < svArr.Length; i++)
        {
            System.Console.WriteLine("Nhap vao phan tu thu " + (i + 1));

            SinhVien sv = new SinhVien();
            
            // Nhap thong tin

            sv.EnterData();

            svArr[i] = sv;
        }

        // Hien thi
        foreach (SinhVien sv in svArr)
        {
            sv.Display();
        }
}

}