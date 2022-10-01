Console.WriteLine("Введите первое целое число: ");
string userInput = Console.ReadLine() ?? "";
int a = int.Parse(userInput);

Console.WriteLine("Введите второе целое число: ");
string userInput2 = Console.ReadLine() ?? "";
int b = int.Parse(userInput2);

Console.WriteLine("Введите третье целое число: ");
string userInput3 = Console.ReadLine() ?? "";
int c = int.Parse(userInput3);

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write(a);
Console.Write(" " + b);
Console.Write(" " + c);
Console.WriteLine(" -> " + max);