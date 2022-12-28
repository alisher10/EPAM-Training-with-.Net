public class NumberConverter
{
    public static void Main()
    {

        Console.WriteLine("Enter number: ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Enter base number from which you want to convert: ");
        int initialBaseNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter base number up to which you want to convert: ");
        int finalBaseNumber = Convert.ToInt32(Console.ReadLine());

        List<int> remainders = new List<int>();

        int number = inputNumber;

        for (int i = initialBaseNumber ; i <= finalBaseNumber; i++)
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