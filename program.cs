string[] FillArray(int size)
{
   string[] array = new string[size];
   for (int i = 0; i < array.Length; i++)
   {
      array[i] = Console.ReadLine();
   }
   return array;
}
void PrintArray(string[] array)
{
   for (int i = 0; i < array.Length - 1; i++)
   {
      Console.Write($"\"{array[i]}\", ");
   }
   Console.Write($"\"{array[array.Length - 1]}\"");
}
int FindNewSize(string[] array)
{
   int count = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i].Length <= 3)
      {
         count++;
      }
   }
   return count;
}

Console.Write("Введите длинну массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = FillArray(n);
Console.Write("[");
PrintArray(array);
Console.Write("] →");
int newSize = FindNewSize(array);