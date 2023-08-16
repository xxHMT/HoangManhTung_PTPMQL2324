// // See https://aka.ms/new-console-template for more information
// int a = 9;
// int b = 3;
// Console.WriteLine("int {0} + {1} = {2} ", a, b, a + b);

internal class Program
{
    private static void Main(string[] args)
    {
        // string HoTen = "Hoang Manh Tung";
        // int Tuoi = 22;
        // Console.WriteLine("Sinh vien {0} - {1} tuoi", HoTen, Tuoi);

        // const string HoTen = "Hoang Manh Tung";
        // const int SoNamLamViec = 8;
        // Console.WriteLine("Nhan vien {0} - {1} nam kinh nghiem", HoTen, SoNamLamViec);

        // int a = 2001;
        // float b = a;
        // Console.WriteLine("b = " + b);

        // string str = "666";
        // VD 1:
        // int a = int.Parse(str);
        // System.Console.WriteLine("a = " + a);


        // VD 2:
        //int KQ;

        // // kiem tra xem chuyen doi co thanh cong hay khong
        // bool KiemTra = false;

        // KiemTra = int.TryParse(str,out(KQ));
        // System.Console.WriteLine("Ket qua = " + KQ);

        // CHUYEN DOI KIEU DU LIEU SU DUNG LOP CONVERT
        // VD:

        // int x = Convert.ToInt32(str);
        // System.Console.WriteLine("x = " + x);

        //5. VD Toan Tu

        // int a, b;

        // System.Console.Write("a = ");// Nhap vao a;

        // a = Convert.ToInt32(Console.ReadLine()); // Chuyen doi kieu du lieu vua nhap sang int va gan cho a

        // System.Console.Write("b = ");

        // b = Convert.ToInt32(Console.ReadLine());

        // System.Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        // System.Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        // System.Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        // System.Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
        // System.Console.WriteLine("{0} % {1} = {2}", a, b, a % b);

        // 6. IF - ELSE

        // int a = 10;        
        
        // if ( a < 0){
        //     System.Console.WriteLine("{0} la so nguyen am", a);
        // }
        // else{
        //     if( a % 2 == 0)
        // {
        //     System.Console.WriteLine("{0} la so nguyen duong chan", a);
        // }
        // else {
        //     System.Console.WriteLine("{0} la so nguyen duong le", a);
        // }
        
        // }

        // 7. Vong lap 

        // 7.1 Vong lap FOR

        // for(int i = 1; i <= 5; i++)
        // {
        //     System.Console.WriteLine("Vong lap thu {0}", i);
        // }

        // 7.2 Vong lap While

        int a = 2;

        while ( a < 8) 
        {
            System.Console.WriteLine("Vong lap thu {0}", a);

            a++;
        }

    }
}