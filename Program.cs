namespace Week_2_Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car("Toyota", "Rav4");
            Car car3 = new Car("Hyundai", "Sonata", 2010, 100000);
            Console.WriteLine(car1.ToString());
            Console.WriteLine(car2.ToString());
            Console.WriteLine(car3.ToString());
        }
    }
}