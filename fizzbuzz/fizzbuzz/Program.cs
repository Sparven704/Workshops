internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Write a number: ");
        int userInput = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        for (int i = 1; i <= userInput; i++)
        {
            if (i%3 == 0 && i%5 != 0)
            {
                Console.Write("fizz" + " ");
            }
            else if (i%5 == 0 && i%3 != 0)
            {
                Console.Write("buzz" + " ");
            }
            else if (i%3 == 0 && i%5 == 0)
            {
                Console.Write("fizzbuzz" + " ");
            }
            else
            {
                Console.Write(i + " ");
            }
            
        }


    }
}