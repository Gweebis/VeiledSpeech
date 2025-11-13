//TODO: format this better plz

using VeiledSpeechPrototype;
Hampter macchi = new Hampter();//TODO: please rename this class gwen i'm begging you, i made it hampter rn so i could move on but istg it cannot stay this

Console.WriteLine("Welcome. We've been expecting you.");
Console.WriteLine("\n\r");

//TODO: This will eventually require functionality to grab a question - refactor to non-hardcode when added.
Prompt prompt = new Prompt("What ails you in this current time? What is your greatest struggle currently, and how does this impact you?");


Console.WriteLine($"I have a question for you.\n\r" + prompt.Question);

prompt.Response = Console.ReadLine();

List<Emotion> emotions = prompt.DetermineResponseEmotions();

Console.WriteLine("Thank you for sharing your thoughts with me.");
Console.WriteLine(macchi.GenerateEmotionalInterpretation(emotions));
Console.WriteLine("Thank you for your time.");
