int[] numbers = new int[10];
Random rnd = new Random();


int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(1, numbers.Length + 1);
    sum += numbers[i];
}

foreach (int i in numbers)
{
    Console.WriteLine(i);
}

Console.WriteLine($"Total sum of the array: {sum}");