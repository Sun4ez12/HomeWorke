Console.WriteLine("Первое число: ");
int num1 = int.Parse(Console.ReadLine () ?? "");
Console.WriteLine("Второе число: ");
int num2 = int.Parse(Console.ReadLine () ?? "");

if (num1 == num2) Console.WriteLine($"Число <{num1} и <{num2} равны>");
else if (num1 > num2) Console.WriteLine($"Среди чисел <{num1}> и <{num2}> максимальное <{num1}>");
else Console.WriteLine($"Среди чисел <{num1}> и <{num2}> максимальное <{num2}>");