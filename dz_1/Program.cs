Console.Clear();

Console.Write("Введите размерность массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] arr = new int [N];
Random rnd = new Random();
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(100, 1000);
}
    foreach (var item in arr)
    {
     System.Console.Write(item + " ");
    }

for (int i = 0; i < arr.Length; i++)
{
    if(arr[i] % 2 == 0)
    {
      count++;  
    }
    
}
System.Console.Write(" \nКоличество четных чисел в массиве: " +count);
