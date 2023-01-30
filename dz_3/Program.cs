Console.Clear();
Console.Write("Введите размерность массива: ");
int N = Convert.ToInt32(Console.ReadLine());
double [] array = new double [N];
Random random = new Random();
double Max = 1.0;

Console.Write("Сгенерированный массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.NextDouble() * 20;
    Console.Write("{0:F2} ", array[i]);
}
Console.Write("\nМаксимальное: ");
Console.WriteLine("{0:F2}", array.Max());
Console.Write("\nМинимальное: ");
Console.WriteLine("{0:F2}", array.Min());
Console.Write("\nРазность: ");
Console.WriteLine("{0:F2}", array.Max() - array.Min());
