string question1 = "What is the capital of Sweden";
string answer1 = "Stockholm";

string question2 = "What is 2+2?";
string answer2 = "4";

string question3 = "Which color is the sky?";
string answer3 = "Blue";

int score = 0;

Console.WriteLine(question1);
string userAnswer1 = Console.ReadLine();
if (answer1 == userAnswer1)
{
    
    Console.WriteLine("It's stockholm indeed.");
    score++;
    Console.WriteLine("You recieved a score.");
}

    else
    {
        Console.WriteLine("Sorry you got that wrong.");
        score-;
        Console.WriteLine("You lost a point.");
    }
Console.WriteLine(question2);
string userAnswer2 = Console.ReadLine();
if (userAnswer2 == answer2)
{
    Console.WriteLine("Correct it's 4. Well done.");
    score++;
    Console.WriteLine("You recieved a score.");
}

 else
{
    Console.WriteLine("That was incorrect.");
    score-;
    Console.WriteLine("You lost a point.");
}
Console.WriteLine(question3);
string userAnswer3 = Console.ReadLine();
if (userAnswer3 == answer3)
{
    Console.WriteLine("Correct");
    score++;
    Console.WriteLine("You recieved a score.");
}

 else
{
    Console.WriteLine("That was incorrect.");
    score-;
    Console.WriteLine("You lost a point.");
}

Console.WriteLine($"Your score is {score}");
