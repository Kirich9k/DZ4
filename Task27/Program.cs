Console.Clear();
Console.Write("Введите число: ");
string? digitForElementSum = Console.ReadLine();
int sumOfElements = 0;
for (int n = 0; n < digitForElementSum.Length; n++)
{
sumOfElements = sumOfElements + int.Parse(digitForElementSum[n].ToString());
}
Console.WriteLine(sumOfElements);