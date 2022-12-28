public class MaxNumberOfUnequalChars
{
    public static void Main()
    {
        List<char> letter = new List<char>();
        Console.WriteLine("Input text:");
        string textInput = Console.ReadLine();
        foreach (var i in textInput)
        {
            if (letter.Contains(i))
            {
                break;
            }
            else
            {
                letter.Add(i);
            }
        }

        Console.WriteLine(letter.Count);


    }
}
