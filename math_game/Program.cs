Console.WriteLine("Please enter your name: \n");

var name = Console.ReadLine();
var date = DateTime.Now;
var questions = new List<string>();

bool active_run = true;

Console.WriteLine("------------------------------------");
Console.WriteLine($"Hello {name}, welcome to today's game: {date} \n");

while (active_run) 
{
    Console.WriteLine("Please choose the operation: \n");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Substraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. View Scoreboards Questions");
    Console.WriteLine("6. Quit");

    int choice = int.Parse(Console.ReadLine());
    int[] ran_num = GenRandNum();

    Console.WriteLine("------------------------------------");
    switch (choice)
    {
        case 1:
            AddGame(ran_num[0], ran_num[1]);
            break;
        case 2:
            SubGame(ran_num[0], ran_num[1]);
            break;
        case 3:
            MultiplyGame(ran_num[0], ran_num[1]);
            break;
        case 4:
            DivisionGame(ran_num[0], ran_num[1]);
            break;
        case 5:
            ViewQuestions(questions);
            break;
        case 6:
            Console.WriteLine("Quitting game ...");
            active_run = false;
            Environment.Exit(1);
            break;
        default:
            Console.WriteLine("Wrong value ... Please choose again =) ");
            break;
    };

    Console.WriteLine("------------------------------------ \n");
}

int[] GenRandNum()
{
    var random = new Random();
    int rand1 = random.Next(0, 100);
    int rand2 = random.Next(0, 100);

    int[] arr = { rand1, rand2 };

    return arr;
}
void AddGame(int n1, int n2) 
{
    Console.WriteLine("Welcome to Addition Game");
    string ques = $"What is the total? {n1} + {n2} ?";
    Console.WriteLine(ques);
    int ans = int.Parse(Console.ReadLine());

    if (ans == n1 + n2) {
        Console.WriteLine("Correct!");   
    }
    else {
        Console.WriteLine($"Wrong! Answer is {n1 + n2}");
    }

    questions.Add($"{ques} Answer is: {n1 + n2}");
}

void SubGame(int n1, int n2)
{
    Console.WriteLine("Welcome to Subtraction Game");
    string ques = $"What is the subtraction? {n1} - {n2} ?";
    Console.WriteLine(ques);
    int ans = int.Parse(Console.ReadLine());

    if (ans == n1 - n2)
    {
        Console.WriteLine("Correct!");
    }
    else
    {
        Console.WriteLine($"Wrong! Answer is {n1 - n2}");
    }

    questions.Add($"{ques} Answer is: {n1 - n2}");

}

void MultiplyGame(int n1, int n2)
{
    Console.WriteLine("Welcome to Multiply Game");
    string ques = $"What is the multiplication? {n1} * {n2} ?";
    Console.WriteLine(ques);
    int ans = int.Parse(Console.ReadLine());

    if (ans == n1 * n2)
    {
        Console.WriteLine("Correct!");
    }
    else
    {
        Console.WriteLine($"Wrong! Answer is {n1 * n2}");
    }

    questions.Add($"{ques} Answer is: {n1 * n2}");

}

void DivisionGame(int n1, int n2)
{
    Console.WriteLine("Welcome to Subtraction Game");
    string ques = $"What is the division? {n1} / {n2} ?";
    Console.WriteLine(ques);
    int ans = int.Parse(Console.ReadLine());

    if (ans == n1 / n2)
    {
        Console.WriteLine("Correct!");
    }
    else
    {
        Console.WriteLine($"Wrong! Answer is {n1 / n2}");
    }

    questions.Add($"{ques} Answer is: {n1 / n2}");
    
}
void ViewQuestions(List<string> questions)
{
    if (questions.Count == 0) 
    {
        Console.WriteLine("No questions has been answered yet!");
    }
    else 
    {
        foreach (string q in questions)
        {
            Console.WriteLine(q);
        }
    }
}
