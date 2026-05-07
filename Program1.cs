int[] numbers = new int[5];

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write("Enter a number:\t");
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        numbers[i] = number;
    }
    else
    {
        Console.WriteLine("Invalid number");
    }
}
Console.Write("Your number is:");
foreach (int number in numbers)
{
    Console.Write($"{number},");
}