namespace Set1Task7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double totalPointFirstPlayer = 0;
            double totalPointSecondPlayer = 0;
            List<int> firstPlayer = new List<int> { 1, 5, 10, 25, 50 };
            List<int> secondPlayer = new List<int> { 1, 5, 10, 25, 50 };
            Random random = new Random();
            int count = 0;
            while (count < 5)
            { 
                count++;
                int index1 = random.Next(firstPlayer.Count);
                int index2 = random.Next(secondPlayer.Count);
                int coinNumerFirstPlayer = firstPlayer[index1];
                firstPlayer.RemoveAt(index1);
                int coinNumerSecondPlayer = secondPlayer[index2];
                secondPlayer.RemoveAt(index2);
                
                if (coinNumerFirstPlayer > coinNumerSecondPlayer)
                {
                    totalPointFirstPlayer = totalPointFirstPlayer + 1;
                }
                else if (coinNumerFirstPlayer < coinNumerSecondPlayer)
                {
                    totalPointSecondPlayer = totalPointSecondPlayer + 1;
                }
                else
                {
                    totalPointFirstPlayer = totalPointFirstPlayer + 0.5;
                    totalPointSecondPlayer = totalPointSecondPlayer + 0.5;
                }
            }
            Console.WriteLine("First Player's points: "+ totalPointFirstPlayer);
            Console.WriteLine("Second Player's points: " + totalPointSecondPlayer);
            if (totalPointFirstPlayer > totalPointSecondPlayer)
            {
                Console.WriteLine("First Player won the game.");
            }
            else if (totalPointFirstPlayer < totalPointSecondPlayer)
            {
                Console.WriteLine("Second Player won the game.");
            }
            else
            {
                Console.WriteLine("Both players have same points.");
            }
        }
    }
}
