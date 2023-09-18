int points = 0;
Console.WriteLine("Greetings, please enter your name.");
string name =Console.ReadLine().ToLower();
Console.WriteLine($"Hello {name}. Thank you for contributing to this quiz. Now for the first question, What is the game masters name?");
string master= Console.ReadLine().ToLower();
if (master=="julius")
{
    ++points;
    Console.WriteLine($"Congratulations {name}, you currently have {points} points!");
   
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
    ++points;
    Console.WriteLine($"That is correct! Congratulations {name} you now have {points} points!");
   

}
else if (anime=="my hero academia"|anime=="bokuno hero academia"|anime=="one piece")
{
    points -=1;
    Console.WriteLine($"You are incorrect, your points have been deducted to {points} points.");
}
else{
    points -=1;
    Console.WriteLine("You have not given a viable answer, your points have been deducted");
    
}
Console.WriteLine("Out of what things listed below, what is Julius most interested in?");
Console.WriteLine("Traveling");
Console.WriteLine("JDM Cars");
Console.WriteLine("Gaming");
Console.WriteLine("Anime");
string interest = Console.ReadLine().ToLower();
if (interest =="jdm cars")
{
    ++points;
    Console.WriteLine("You are correct! He loves JDM Cars, specifically the Toyota Supra Mk4 and Nissan R-34 Skyline");
    Console.WriteLine($"You are currently at {points} points!");
    }
else
{
    points -=1;
    Console.WriteLine($"Unfortunately your answer was incorreect");
    Console.WriteLine($"You currently have {points} points");
}
Console.WriteLine($"What game is Julius favourite? pick from the list below");
Console.WriteLine("Genshin Impact");
Console.WriteLine("Ark Survival Evolved");
Console.WriteLine("Valorant");
Console.WriteLine("CS GO");
string game = Console.ReadLine().ToLower();
if (game =="ark survival evolved")
{
    ++points;
    Console.WriteLine($"You have entered the correct answer, you are now at {points}");
}
else 
{
    Console.WriteLine($"Unfortunately you have entered the incorrect answer, your points are currently at {points} points!");
}

if (points == 4)
{
    Console.WriteLine($"Congratulations, {name} you have successfully completed the game with a full score!");
}
else if (points == 2|points== 3)
{
    Console.WriteLine($"Congratulations, {name} you have successfully made it with {points} better luck next time!");
}
else if (points == 1)
{
    Console.WriteLine($"Unfortunately you have finished this quiz with {points} points, you may try again...");
}
else
{
    Console.WriteLine($"You have gotten {points} points in this quiz, you fail.");
}
Console.ReadLine();