Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine () ?? "");

int Number = 2;
Console.Write($"Четные числа от <1> до <{num}> :");
while (Number < num)
{
    Console.Write($" {Number}");
    Number = Number + 2;
}
Console.WriteLine("");