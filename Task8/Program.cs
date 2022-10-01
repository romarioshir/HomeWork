Console.Write("Введите целое число: ");
string userInput = Console.ReadLine() ?? "";
int a = int.Parse(userInput);

int count = 1;

Console.Write(a + " -> ");

while (count < a + 1)
{
    if (count % 2 == 0)
    {
    Console.Write(count + " "); //Прошу пояснения в комментарии по поводу этой строчки, а именно что делает и почему работает (переменная + " ") ?
    }
    count++;

}
