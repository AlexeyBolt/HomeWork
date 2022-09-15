Console.Clear();
Console.WriteLine("Введите число A");
string input = Console.ReadLine();
int a = int.Parse(input);
Console.WriteLine("Введите число B");
string input2 = Console.ReadLine();
int b = int.Parse(input2);
Console.WriteLine("Введите число C");
string input3 = Console.ReadLine();
int c = int.Parse(input3);

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;


Console.Write("Большее число =");
Console.WriteLine(max);
