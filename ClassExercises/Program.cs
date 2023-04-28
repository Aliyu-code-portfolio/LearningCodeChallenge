
using ClassExercises;
bool loop=true;
while (loop)
{
    Console.WriteLine("Enter a sentence to analyse");
    string? sentence = Console.ReadLine();
    VowelConsonantCount vc = new(sentence);
    vc.GetVowelConsonantDetails();
    Console.WriteLine();
    Console.WriteLine("Do you want to test another sentence? NO/YES");
    string choice = Console.ReadLine();
    switch (choice.ToLower())
    {
        case "yes":
            
            break;
        case "no":
        default:
            loop = false;
            break;
    }
}
