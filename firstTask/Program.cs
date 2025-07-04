namespace firstTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many small carpets do you want to clean?");
            int minValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many large carpets do you want to clean?");
            int maxValue = Convert.ToInt32(Console.ReadLine());
            int costValue = (maxValue * 35) + (minValue * 25);
            double tax = (costValue * 0.06);
            double total = costValue + tax;
            Console.WriteLine( "ok your final amount is: " + total);
        }
    }
}
