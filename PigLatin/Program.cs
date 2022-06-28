//PigLatin
//Translate from English to Pig Latin.

Console.WriteLine("Welcome to the Pig Latin Translator!");

while (true)
{
    Console.WriteLine("Please enter a word.");

    string input = Console.ReadLine();
    if (input == "")
    {
        Console.WriteLine("Please enter text to translate");
        continue;
    }

    char first = input[0];
    char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

    if (vowels.Contains(first))
    {
        ConvertVowel(ref input);
    }
    //Starts with consonant, move all consonants that appear before the first vowel to the end,
    //then add "ay" to the end of the word
    else
    {
        ConsonantConvert(ref input);
    }

    Console.WriteLine("Do you want to translate another word? y/n ");

    string restart = Console.ReadLine().ToLower();
    if (restart == "yes" || restart == "y")
    {
        continue;
    }
    else
    {
        Console.WriteLine("Thank you for playing!");
        break;
    }
}

static string ConvertVowel(ref string input)
{
    string newWord = (input + "way");
    Console.WriteLine(newWord);
    return newWord;

}

static void ConsonantConvert(ref string input) 
{
    int vowelPosition = -1; 
    string newStart = ""; 
    string moveThis = ""; 

    char[] letterBank = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

    foreach (char letter in input)
    {
        vowelPosition++;

        if (letterBank.Contains(letter))
        {
            moveThis = input.Substring(0, vowelPosition);  

            int remainingLetters = (input.Length - moveThis.Length); 

            newStart = input.Substring(vowelPosition, remainingLetters);

            string newWord = (newStart + moveThis + "ay");
            Console.WriteLine(newWord);
            break;
        }
    }

}
