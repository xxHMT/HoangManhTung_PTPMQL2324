namespace NewApp.Models
{
    public class GiaiPT
    {
        
        public int a { get; set; }
        public int b { get; set; }

    
        double x;
        public void NhapHeSo()
        {
            System.Console.Write("Nhap vao he so a = ");
            a = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Nhap vao he so b = ");
            b = Convert.ToInt32(Console.ReadLine());
        }

        public void GiaiPTB1()
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("PT co vo so nghiem");
                }
                else {
                    Console.WriteLine("PT vo nghiem");
                }
            }
            else
            {
                x = (double) -b / a;
                Console.WriteLine("PT co nghiem x = {0}", Math.Round(x, 2));
            }
        }
    }
}