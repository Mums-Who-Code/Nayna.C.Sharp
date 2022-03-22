namespace Set1Task3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name;
            string yourJoiningDate;
            DateTime dt;
            Console.WriteLine("Enter your name :");
            name = Console.ReadLine().Trim();

            if (name == null || name == "")
            {
                Console.WriteLine("Invalid Input.");
            }
            else
            {
                Console.WriteLine("Enter your joining date on MumsWhoCode(format : MM/dd/yyyy) :");
                yourJoiningDate = Console.ReadLine();
                var isValidDate = DateTime.TryParse(yourJoiningDate, out dt);

                if (isValidDate)
                {
                    Console.WriteLine($"My name is {name}.");
                    Console.WriteLine("I joined MumsWhoCode on " + dt.ToString("MM/dd/yyyy") + ".");
                }
                else
                {
                    Console.WriteLine("This is not a valid date string.");
                }
            }

            Console.ReadLine();
        }
    }
}