namespace Set1Task6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random dice = new Random();
            int firstPlayer = dice.Next(1, 7);
            int secondPlayer = dice.Next(1, 7);
            int thirdPlayer = dice.Next(1, 7);
            int fourthPlayer = dice.Next(1, 7);
            int fifthPlayer = dice.Next(1, 7);
            Console.WriteLine($"First Player: {firstPlayer}");
            Console.WriteLine($"Second Player: {secondPlayer}");
            Console.WriteLine($"Third Player: {thirdPlayer}");
            Console.WriteLine($"Fourth Player: {fourthPlayer}");
            Console.WriteLine($"Fifth Player: {fifthPlayer}");
            List<int> diceNumbers = new List<int>();
            diceNumbers.Add(firstPlayer);
            diceNumbers.Add(secondPlayer);
            diceNumbers.Add(thirdPlayer);
            diceNumbers.Add(fourthPlayer);
            diceNumbers.Add(fifthPlayer);
            Console.WriteLine("Players who moved to the next level: ");

            if(ContainsValue(diceNumbers, firstPlayer))
            {
                Console.WriteLine("First Player");
            }
            if(ContainsValue(diceNumbers, secondPlayer))
            {
                Console.WriteLine("Second Player");
            }
            if(ContainsValue(diceNumbers, thirdPlayer))
            {
                Console.WriteLine("Third Player");
            }
            if(ContainsValue(diceNumbers, fourthPlayer))
            {
                Console.WriteLine("Fourth Player");
            }
            if(ContainsValue(diceNumbers, fifthPlayer))
            {
                Console.WriteLine("Fifth Player");
            }

            Console.WriteLine("Players who did not moved to the next level: ");

            if (!ContainsValue(diceNumbers, firstPlayer))
            {
                Console.WriteLine("First Player");
            }
            if (!ContainsValue(diceNumbers, secondPlayer))
            {
                Console.WriteLine("Second Player");
            }
            if (!ContainsValue(diceNumbers, thirdPlayer))
            {
                Console.WriteLine("Third Player");
            }
            if (!ContainsValue(diceNumbers, fourthPlayer))
            {
                Console.WriteLine("Fourth Player");
            }
            if (!ContainsValue(diceNumbers, fifthPlayer))
            {
                Console.WriteLine("Fifth Player");
            }
        }

        static bool ContainsValue(List<int> list, int diceNumber)
        {
            int count = 0;
            foreach (int number in list)
            {
                if (number == diceNumber)
                {
                    count++;
                }
            }
            if (count > 1)
            {
                return true;
            }
            return false;
        }
    }
}
