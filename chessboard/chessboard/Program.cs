

using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.Unicode;
int[] myNumbers = { 14, 22, 7, 19 };
Console.WriteLine("Welcome to the Chess Board");
Console.Write("How large board? ----> ");
string input = Console.ReadLine();
bool isNumber = int.TryParse(input, out int value);

static void printBoard(string[] arr)
{
    Console.WriteLine("Array elements...");
    foreach (string item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

// Skapa ett shackbräde som value x value stort
// Skapa en endimensionell array med value^2 antal element
string[] board = new string[value * value];


for (int i = 0; i < board.Length; i++)
{
    //Console.Write("Enter " + i + " element: ");
    
    if (i % 2 == 0)
    {
        //even number
        board[i] = "X";
    } else
    {
        //uneven number
        board[i] = "O";
    }
}

printBoard(board);
