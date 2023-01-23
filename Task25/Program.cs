Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень, в которую надо возвести это число: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i <= b; i++)
{
    result = result * a;
}
Console.WriteLine(result);