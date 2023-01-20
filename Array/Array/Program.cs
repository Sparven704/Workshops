Console.WriteLine("Hello, please enter the size of this array: ");
int userInput = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Enter " + userInput + " numbers: ");

int n;
int[] array = new int[userInput];
n = userInput;
for (int i = 0; i < n; i++)
{
    array[i] = int.Parse(Console.ReadLine());
    
}
Console.WriteLine("----------------------------");
for (int j = (userInput-1); j >= 0; j--)
{
    Console.WriteLine(array[j]);
}
