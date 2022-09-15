Console.Clear();
Console.WriteLine("Введите положительное число");
int num = int.Parse(Console.ReadLine());

int count = 2;

while (count <= num)
{
    Console.Write($"{count} ");
    count = count + 2;
}