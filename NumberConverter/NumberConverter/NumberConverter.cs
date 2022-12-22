public class NumberConverter
{
    static void Main()
    {

        Console.WriteLine("Enter number: ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        List<int> remainders = new List<int>();

        int number = inputNumber;

        for (int i = 2; i < 21; i++)
        {
            while (inputNumber != 0)
            {
                int remainder;
                remainder = inputNumber % i;
                remainders.Add(Convert.ToInt32(remainder));
                inputNumber = inputNumber / i;
            }
            remainders.Reverse();

            Console.Write("Answer is: ");
            foreach (var j in remainders)
            {
                Console.Write(j);
            }
            Console.WriteLine("\n=============================");
            inputNumber = number;
            remainders.Clear();

        }

    }
}