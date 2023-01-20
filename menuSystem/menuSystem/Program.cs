using menuSystem;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Välkommen till min projektsamling! Vänligen välj ett av nedanstående alternativ: ");
        Console.WriteLine("1. Hello World");
        Console.WriteLine("2. Guess a Number");
        Console.WriteLine("3. Rock Paper Scissors");
        Console.WriteLine("S. Slumpmässigt projekt");
        Console.WriteLine("G. Link to my Github");
        Console.WriteLine("A. Avsluta");

        string userInput = Console.ReadLine();
        
        switch(userInput) {
            case "1":
                Console.WriteLine("");
                Console.WriteLine("----> 1.");
                Console.WriteLine("");
                helloWorld newWorld = new helloWorld();
                Console.WriteLine(newWorld);
                break;

            case "2":
                Console.WriteLine("");
                Console.WriteLine("----> 2.");
                Console.WriteLine("");
                GuessANumber newGuessANumber = new GuessANumber();
                Console.WriteLine(newGuessANumber);
                break;
            case "3":
                Console.WriteLine("");
                Console.WriteLine("----> 3.");
                Console.WriteLine("");
                RockPaperScissors RPS = new RockPaperScissors();
                Console.WriteLine(RPS);
                break;
            case "S":
                Console.WriteLine("");
                Console.WriteLine("----> S.");
                Console.WriteLine("");
                Random random = new Random();
                int number = random.Next(1, 3);
                if (number == 1)
                {
                    helloWorld newWorld2 = new helloWorld();
                    Console.WriteLine(newWorld2);
                }
                else if (number == 2)
                {
                    GuessANumber newGuessANumber2 = new GuessANumber();
                    Console.WriteLine(newGuessANumber2);
                }
                else
                {
                    RockPaperScissors RPS2 = new RockPaperScissors();
                    Console.WriteLine(RPS2);
                }

                break;
            case "G":
                Console.WriteLine("");
                Console.WriteLine("----> G.");
                Console.WriteLine("");
                Console.WriteLine("https://github.com/Sparven704");

                break;
            case "A":
                Console.WriteLine("");
                Console.WriteLine("----> A.");
                Console.WriteLine("");
                Console.WriteLine("Thanks for stopping in, have a nice day.");
                return;
                
        }
    }
    class helloWorld
    {
        public helloWorld()
        {
            Console.WriteLine("Hello World!");
        }
    }
   
   

}