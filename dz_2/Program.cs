Console.Clear();

Console.Write("Введите размерность массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int [N];
int count = 0;
int result = 0;
Random rnd = new Random();

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(100);
    
}
foreach (var item in numbers)
{
    Console.Write(item + " ");
}
for (int i = 0; i < numbers.Length; i++)
{
    if(i % 2 != 0)
    {
      count = count + numbers[i];
    }
    
}
System.Console.Write(" \nСумма элементов стоящих на нечётных позициях: " +count);