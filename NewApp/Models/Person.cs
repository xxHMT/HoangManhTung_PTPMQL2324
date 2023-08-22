namespace NewApp.Models
{
    public class Person
    {
        public string FullName { get; set; }
        public string Address { get; set;}
        public int Age { get; set;}

        public void EnterData()
        {
            FullName = "Nguyen Van A";
            Address = "Ha Noi";
            Age = 21;
        }

        public int GetYearOfBirth(int Age)
        {
            int yearOfBirth = 2023 - Age;
            return yearOfBirth;
        }

        public void Display()
        {
            System.Console.WriteLine("{0} - {1} - {2} tuoi", FullName, Address, Age);
        }
    }
}