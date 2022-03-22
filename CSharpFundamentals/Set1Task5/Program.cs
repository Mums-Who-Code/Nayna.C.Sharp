namespace Set1Task5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime currentDateTime1 = DateTime.Now;
            Console.WriteLine(currentDateTime1.ToString());
            Console.WriteLine("Please enter a random integer number: ");

            try
            {
                int days = int.Parse(Console.ReadLine());
                DateTime newDateTime1 = currentDateTime1.AddDays(days);
                Console.WriteLine(newDateTime1.ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("You didn't entered a valid integer number. Try again.");
            }
        }
    }
}