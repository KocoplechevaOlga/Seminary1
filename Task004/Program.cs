// See https://aka.ms/new-console-template for more information
Console.WriteLine("ВВедите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = -number;

while (count <= number)
{
    Console.Write($"{count }");
    count++;
}