Console.Clear();
Console.Write("Введите количество слов в массиве: ");
int n = int.Parse(Console.ReadLine());
string[] words = new string[n];
Console.WriteLine("Введите слова через пробел:");
string input = Console.ReadLine();
words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);