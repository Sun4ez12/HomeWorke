Console.WriteLine("Число: ");
int numTest = int.Parse(Console.ReadLine () ?? "");

if(numTest % 2 == 0) Console.WriteLine($"Число: {numTest} - Четное");
else Console.WriteLine($"Число: {numTest} - Нечетное");