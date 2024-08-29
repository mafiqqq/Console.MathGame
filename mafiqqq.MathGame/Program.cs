namespace mafiqqq.MathGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************************************");
            Console.WriteLine("*************  WELCOM TO THE MATH GAME  **************");
            Console.WriteLine("******************************************************");

            Console.WriteLine();
            MathGameLogic maths = new MathGameLogic();

            // Loop until exit
            while (true)
            {
                int operation = maths.ShowMenu();

                // Check for show history and exit
                if (operation == 6)
                {
                    maths.ShowHistory();
                }
                else if (operation == 7)
                {
                    maths.ExitGame();
                }
                else 
                {
                    (int num1, int num2) = maths.GenerateRandNum();

                    // Get real answer
                    int ans = maths.MathOperation(num1, num2, operation);

                    // Ask user for answer
                    string userInput = Console.ReadLine();

                    Console.WriteLine(ans == Convert.ToInt32(userInput) ? "Correct!" : "False!");
                }
            }
        }
    }
}