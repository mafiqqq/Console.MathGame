using System.Diagnostics;

namespace mafiqqq.MathGame
{
    public class MathGameLogic
    {

        List<string> MathHistory = new List<string>();

        public int ShowMenu()
        {
            bool invalidInput = true;
            int operation = 0;

            while (invalidInput)
            {
                Console.WriteLine("Please enter the operation you would like to perform:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Random Mode");
                Console.WriteLine("6. Show History");
                Console.WriteLine("7. Exit");

                if (int.TryParse(Console.ReadLine(), out operation) && operation >= 1 && operation <= 7)
                {
                    invalidInput = false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please choose option from 1-7. Try again..");
                }
            }

            return operation;

        }

        public int MathOperation(int firstNum, int secondNum, int operation)
        {
            char oper;
            while (true) 
            {
                switch (operation)
                {
                    case 1:
                        oper = '+';
                        MathHistory.Add($"{firstNum} + {secondNum} = {firstNum + secondNum}");
                        GenerateQuestion(firstNum, secondNum, oper);
                        return firstNum + secondNum;
                    case 2:
                        oper = '-';
                        MathHistory.Add($"{firstNum} - {secondNum} = {firstNum - secondNum}");
                        GenerateQuestion(firstNum, secondNum, oper);
                        return firstNum - secondNum;
                    case 3:
                        oper = '*';
                        MathHistory.Add($"{firstNum} * {secondNum} = {firstNum * secondNum}");
                        GenerateQuestion(firstNum, secondNum, oper);
                        return firstNum * secondNum;
                    case 4:
                        oper = '/';

                        // Check for division integer
                        while (firstNum % secondNum != 0)
                        {
                            (firstNum, secondNum) = GenerateRandNum();
                        }

                        MathHistory.Add($"{firstNum} / {secondNum} = {firstNum / secondNum}");
                        GenerateQuestion(firstNum, secondNum, oper);
                        return firstNum / secondNum;
                    case 5:
                        Console.WriteLine("\nChoosing random operation question ...");
                        Random rand = new Random();
                        operation = rand.Next(1, 4);
                        continue;
                }
            }
        }

        internal void GenerateQuestion(int firstNum, int secondNum, char oper)
        {
            Console.WriteLine();
            Console.WriteLine($"What is the value of {firstNum} {oper} {secondNum} ?");
        }

        public (int, int) GenerateRandNum()
        {
            Random rnd = new Random();
            int num1 = rnd.Next(1, 100);
            int num2 = rnd.Next(1, 100);
            return (num1, num2);
        }

        public void ShowHistory()
        {

            if (MathHistory.Count == 0)
            {
                Console.WriteLine("No questions were asked yet..");
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("List of questions asked before:");

                foreach (string var in MathHistory)
                {
                    Console.WriteLine(var);
                }

                Console.WriteLine("Press enter or any key to continue to the menu ...");
                Console.ReadKey();

                Console.Clear();
            }
        }

        public void ExitGame()
        {
            Console.WriteLine("Thank you for playing Math Game!");
            Console.WriteLine("Exiting the program...");
            Thread.Sleep(2000);
            Environment.Exit(0); // Exit the application with a success code
        }
    }
}
