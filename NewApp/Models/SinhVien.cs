namespace NewApp.Models
{
    public class SinhVien
    {
        public string FullName { get; set; }
        public string Address { get; set;}
        public int Age { get; set;}

        public int PhoneNumber { get; set; }

        public void EnterData()
        {
            System.Console.Write("Full name = ");
            FullName = Console.ReadLine();
            System.Console.Write("Address = ");
            Address = Console.ReadLine();
            System.Console.Write("Age = ");
            Age = Convert.ToInt16(Console.ReadLine());
            System.Console.Write("Phone number = ");
            PhoneNumber = Convert.ToInt16(Console.ReadLine());
        }

        public void Display()
        {
            System.Console.WriteLine("{0} - {1} - {2} tuoi - SDT: {3}", FullName, Address, Age, PhoneNumber);
        }
    }
}