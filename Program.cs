Console.WriteLine("Wake up, Neo...");
Console.ReadKey();
Console.Clear();

var str = "The Matrix has you...";
foreach(char c in str)
{
    Console.Write(c);
    Thread.Sleep(100);
}
Console.ReadKey();
Console.Clear();

str = "Follow the white rabbit.";
foreach(char c in str)
{
    Console.Write(c);
    Thread.Sleep(50);
}
Console.ReadKey();
Console.Clear();

Console.WriteLine("Knock, knock, Neo.");
Console.ReadKey();
Console.Clear();