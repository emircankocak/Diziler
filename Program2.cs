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


int max = numbers[0];
int min = numbers[0];

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {

        if (numbers[i] > max)
        {
            max = numbers[i];
        }
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }
}
Console.WriteLine($"\nThe largest element:\t{max}");
Console.WriteLine($"The smallest element:\t{min}");

