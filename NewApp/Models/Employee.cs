namespace NewApp.Models
{
    public class Employee : Person
    
    {
        public string EmployeeID {get ; set; }

        public void EnterData()
        {
            base.EnterData();
            System.Console.Write("Employee ID = ");
            EmployeeID = Console.ReadLine();
        }

        public void Display()
        {
            base.Display();
            System.Console.WriteLine("- ID: {0}", EmployeeID);
        }
    }
}