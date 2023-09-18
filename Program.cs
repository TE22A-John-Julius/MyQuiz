int points = 0;
int perfect = 3;
Console.WriteLine("Greetings, please enter your name.");
string name =Console.ReadLine().ToLower();
Console.WriteLine($"Hello {name}. Thank you for contributing to this quiz. Now for the first question, What is the game masters name?");
string master= Console.ReadLine().ToLower();
if (master=="julius")
{
    points += 1;
    Console.WriteLine($"Congratulations {name}, you currently have {points} points!");
    perfect ++;
}
else
{
    Console.WriteLine($"Unfortunately you have gotten the question wrong points have been deducted, maybe you should introduce yourself");
    points -= 1;
}
Console.WriteLine($"Have you introduced yourself and remember the name of the game master?");
string introduction = Console.ReadLine().ToLower();
if (introduction =="yes")
{
    Console.WriteLine("Congratulations you've passed the first test of the quiz");
    perfect ++;
}
else if (introduction=="no")
{
    points -=1;
    Console.WriteLine($"Please introduce yourself and then continue the quiz your score have been deducted to {points} points!");
}
else{
    points -=1;
    Console.WriteLine($"You have not given a viable answer, your points have been deducted to {points}");
    
}
Console.WriteLine($"Now onto the main questions, what anime do you think is Julius favorite. Pick from the following");
Console.WriteLine("Sword Art Online");
Console.WriteLine("My Hero Academia / boku no hero academia");
Console.WriteLine("One Piece");
string anime = Console.ReadLine().ToLower();
if (anime=="sword art online")
{
    Console.WriteLine($"That is correct! Congratulations {name} you now have {points} points!");

}
else if (anime=="my hero academia"|anime=="bokuno hero academia"|anime=="one piece")
{
    points -=1;
    Console.WriteLine($"You are incorrect, your points have been deducted to {points} points.");
}
else{
    Console.WriteLine("You have not given a viable answer, your points have been deducted");
    points -=1;
}
Console.WriteLine("Out of what things listed below, what is Julius most interested in?");
Console.WriteLine("Traveling");
Console.WriteLine("JDM Cars");
Console.WriteLine("Gaming");
Console.WriteLine("Anime");
string interest = Console.ReadLine().ToLower();
if (interest =="jdm cars")
{
    points += 1;
    Console.WriteLine("You are correct! He loves JDM Cars, specifically the Toyota Supra Mk4 and Nissan R-34 Skyline");
    Console.WriteLine($"You are currently at {points} points!");
    }
else
{
    points -=1;
    Console.WriteLine($"Unfortunately your answer was incorreect");
}