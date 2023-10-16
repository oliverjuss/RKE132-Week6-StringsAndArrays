//string[] fruit = { "apples", "bannanas", "oranges",};
string[] fruit = new string[3];

fruit[0] = "apples";
fruit[1] = "bannas";
fruit[2] = "oranges";
Console.WriteLine($"{fruit[0]},{fruit[1]},{fruit[2]}");

int fruitArrayLength = fruit.Length;

Console.WriteLine($"There are {fruitArrayLength} in the arrray ");


for (int i = 0; i < fruitArrayLength; i++)
{
    fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0]));
}

foreach (string fruitString in fruit)
{
    Console.WriteLine(fruitString);
}