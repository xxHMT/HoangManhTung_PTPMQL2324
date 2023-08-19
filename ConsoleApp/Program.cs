// // See https://aka.ms/new-console-template for more information
// int a = 9;
// int b = 3;
// Console.WriteLine("int {0} + {1} = {2} ", a, b, a + b);

internal class Program
{
    private static void Main(string[] args)
    {
        string str = "666";
       int KQ;

        // kiem tra xem chuyen doi co thanh cong hay khong
        bool KiemTra = false;

        KiemTra = int.TryParse(str,out(KQ));
        System.Console.WriteLine("Ket qua = " + KQ);
    }
}
