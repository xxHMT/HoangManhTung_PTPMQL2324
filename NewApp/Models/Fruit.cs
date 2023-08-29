namespace NewApp.Models
{
    public class Fruit
    {
        public string FruitName { get; set; }
        public string FruitType { get; set; }
        public int FruitPrice { get; set; }
    

    public void EnterData()
    {
        System.Console.Write("Fruit Name = ");
        FruitName = Console.ReadLine();
        System.Console.Write("Fruit Type = ");
        FruitType = Console.ReadLine();
        System.Console.Write("Fruit Price = ");
        FruitPrice = Convert.ToInt32(Console.ReadLine());
    }

    public void Display()
    {
        System.Console.WriteLine("{0} - {1} - {2} VND", FruitName, FruitType, FruitPrice);
    }
    }
}