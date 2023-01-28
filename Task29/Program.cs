Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
Console.WriteLine($"Введите {i+1} элемент массива: ");
array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");