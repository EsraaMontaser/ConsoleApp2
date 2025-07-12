namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("    Welcome To Islam's carpet cleaning service     ");
            Console.WriteLine("Charges:  ");
            Console.WriteLine("Price per small room: $25");
            Console.WriteLine("Price per large room: $35");
            Console.WriteLine("Sales tax rate is 6%");
            Console.WriteLine("Estimates are valid for 30 days");
            Console.WriteLine("Number of your small carpets: ");
            int smallCarpets = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Number of your large carpets: ");
            int largeCarpets = Convert.ToInt32(Console.ReadLine());
            int cost = (smallCarpets * 25) + (largeCarpets * 35);
            double tax = cost * 0.06;
            double totalEstimate = cost + tax;
            Console.WriteLine($"Cost = {cost}");
            Console.WriteLine($"Tax = {tax}");
            Console.WriteLine($"Total estimate = {totalEstimate}");

        }
    }
}
