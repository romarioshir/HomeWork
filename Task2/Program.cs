Console.WriteLine("Введите целое число: ");
string userInput = Console.ReadLine() ?? "";
int a = int.Parse(userInput);

Console.WriteLine("Введите целое число: ");
string userInput2 = Console.ReadLine() ?? "";
int b = int.Parse(userInput2);

if (a > b)
{
Console.WriteLine("a = " + a + " , b = " + b + " , max = " + a);
}
else
{
Console.WriteLine("a = " + a + " , b = " + b + " , max = " + b);
}