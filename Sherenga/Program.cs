Console.Clear();
int n = 8;
Console.WriteLine("Введите рост Пети: ");
int p = int.Parse(Console.ReadLine());
int[]array=new int[n];
for (int i = 0; i < n; i++)
{
array[i] = new Random().Next(150, 180);
//Console.Write($"{array[i]} ");
}
Array.Sort(array);
Array.Reverse(array);
//Console.WriteLine();
 for (int i = 0; i < n; i++)
 {
Console.Write($"{array[i]} ");
}
               

    
   
   
   


