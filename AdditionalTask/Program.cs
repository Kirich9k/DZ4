Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int[] shiftedArray = new int [n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 101);
Console.WriteLine($"[{string.Join(", ", array)}]");    
Console.Write("Введите смещение элементов массива: ");
int shift = Convert.ToInt32(Console.ReadLine());
shift = shift % n;
if (shift > 0)
{
    for (int i = 0; i < shift; i++)
        shiftedArray[i] = array[array.Length - shift + i];
    for (int i = 0; i < array.Length - shift; i++)
        shiftedArray[shift + i] = array[i];
    Console.WriteLine($"[{string.Join(", ", shiftedArray)}]");
}
else 
{
    shift = -shift;
    for (int i = 0; i < shift; i++)
        shiftedArray[n - shift + i] = array[i];
    for (int i = 0; i < array.Length - shift; i++) 
        shiftedArray[i] = array[shift + i];
    Console.WriteLine($"[{string.Join(", ", shiftedArray)}]");
}