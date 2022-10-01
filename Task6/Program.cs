Console.Write("Введите целое число: ");
string userInput = Console.ReadLine() ?? "";
int a = int.Parse(userInput);

if (a % 2 == 0)
{
Console.WriteLine(a + " -> да");
}
else
{
Console.WriteLine(a + " -> нет");
}