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
               
// int n = 8;
// int Petya = 162;
// // int[]class = {165,163,160,160,157,157,155,154};
// // int n = class.Length;
// // for (int i=0; i<n; i++)
// // Console.Write({class[i]});

//     // if (array[i]<array[i+1]){
//     // // int b = array[i];
    // // array[i] = array[i+1];
    // array[i+1] = b;
    
   
   
   


