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

            BankAccount bankAccount = new BankAccount("123456789", "Wayne Campbell", 20);
            Console.WriteLine(bankAccount.ToString());
            bankAccount.Deposit(500);
            Console.WriteLine(bankAccount.ToString());
            bankAccount.Deposit(-15000);
            Console.WriteLine(bankAccount.ToString());
            bankAccount.Withdraw(300);
            Console.WriteLine(bankAccount.ToString());
            bankAccount.Withdraw(-500);
            Console.WriteLine(bankAccount.ToString());


        }
    }
}