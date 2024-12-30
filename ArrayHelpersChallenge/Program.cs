// See https://aka.ms/new-console-template for more information

Console.WriteLine("\nChallenge: 1");
string pangram = "The quick brown fox jumps over the lazy dog";

string[] pangramArray = pangram.Split(" ");
string[] reveredWordArray = new string[pangramArray.Length];

for (int i = 0; i < pangramArray.Length; i++)
{
    char[] letters = pangramArray[i].ToCharArray();
    Array.Reverse(letters);
    pangramArray[i] = new string(letters);
}

pangram = String.Join(" ", pangramArray);
Console.WriteLine(pangram);



Console.WriteLine("\nChallenge: 2");
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orders = orderStream.Split(",");
Array.Sort(orders);

foreach (string order in orders)
{
    if (order.Length == 4)
        Console.WriteLine(order);
    else
        Console.WriteLine($"{order}\t- Error");
}

Console.WriteLine("");