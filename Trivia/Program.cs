int sum = 0;

Console.WriteLine("Press enter to start the quiz");
Console.ReadLine();

Console.WriteLine("In what year did the japanese film Batlle Royale come out?");
Console.WriteLine("a. 2000");
Console.WriteLine("b. 2008");
Console.WriteLine("c. 2010");

string film = Console.ReadLine().ToLower();

if (film == "a")
{
    sum++;
    Console.WriteLine("Correct!");
}
else
{
    Console.WriteLine("Incorrect.");
}

Console.WriteLine("");
Console.WriteLine("From what anime is David Martinez from?");
Console.WriteLine("a. Berserk");
Console.WriteLine("b. Jujutsu Kaisen");
Console.WriteLine("c. Cyberpunk Edgerunners");

string anime = Console.ReadLine().ToLower();

if (anime == "c")
{
    sum++;
    Console.WriteLine("Correct!");
}
else
{
    Console.WriteLine("Incorrect.");
}

Console.WriteLine("");
Console.WriteLine("Which one out of these artists are from Sweden?");
Console.WriteLine("a. Yung Lean");
Console.WriteLine("b. Playboi Carti");
Console.WriteLine("c. Semetary");

string artist = Console.ReadLine().ToLower();

if (artist == "a")
{
    sum++;
    Console.WriteLine("Correct!");
}
else
{
    Console.WriteLine("Incorrect.");
}

Console.WriteLine("");
Console.WriteLine("Who is the best teacher at NTI?");
Console.WriteLine("a. Carl Engman");
Console.WriteLine("b. Mikael Bergström");
Console.WriteLine("c. Liv Sundman");

string teacher = Console.ReadLine().ToLower();

if (teacher == "b")
{
    sum++;
    Console.WriteLine("Correct! No one comes close to Micke B.");
}
else
{
    Console.WriteLine("Incorrect. Micke B simply is the best.");
}

Console.WriteLine("");
Console.WriteLine("Last question...");
Console.WriteLine("");
Console.WriteLine("What is my instagram? (phones are allowed for this part)");
Console.WriteLine("a. @sverrekallberg");
Console.WriteLine("b. @sverrekal");
Console.WriteLine("c. @sverrenomen");

string insta = Console.ReadLine().ToLower();

if (insta == "c")
{
    sum++;
    Console.WriteLine("Correct!");
}
else
{
    Console.WriteLine("Incorrect. @sverrenomen is the correct answer");
}

// Shous frågor

Console.WriteLine("Who is the main character of6 the move How to train your Dragon?");
Console.WriteLine("a.Hicc ");
Console.WriteLine("b.Hiccup ");
Console.WriteLine("c.Toothless ");

string Dragon = Console.ReadLine().ToLower();

if (Dragon == "b")
{
    sum++;
    Console.WriteLine("Correct! Toothless is Hiccup's dragon.");
}
else
{
    Console.WriteLine("Incorrect.");
}

Console.WriteLine("Do you like Sweden?");
Console.WriteLine("a.Yes, I am. ");
Console.WriteLine("b.Of course ");
Console.WriteLine("c.No ");

string YesIam = Console.ReadLine().ToLower();

if (YesIam == "a")
{
    sum++;
    Console.WriteLine("Correct! I like Sweden!!");
}
else
{
    Console.WriteLine("Incorrect. This is a simple English sentence problem.");
}

Console.WriteLine("");
Console.WriteLine($"Your score was {sum} out of 7!");
if (sum == 0)
{
    Console.WriteLine("Better luck next time.");
}
else if (sum < 3)
{
    Console.WriteLine("Not the best score, but atleast some correct answers.");
}
else if (sum < 5)
{
    Console.WriteLine("Good job! Not every question correct but almost there.");
}
else
{
    Console.WriteLine("Well done.");
}

Console.WriteLine("");
Console.WriteLine("Press any key to end");
Console.ReadKey();