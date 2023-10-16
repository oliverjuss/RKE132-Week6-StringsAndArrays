string[] snacks = { "sushi", "pizza", "burger", "chicken wings", "Asian takeway" };

Random rnd = new Random();

Console.WriteLine($"We are gonna eat today: { snacks[rnd.Next(0, snacks.Length)]}");