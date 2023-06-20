string[] FillArray(int size)
{
   string[] array = new string[size];
   for (int i = 0; i < array.Length; i++)
   {
      array[i] = Console.ReadLine()!;
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
string[] CreateNewArray(string[] array, int size)
{
   string[] newArray = new string[size];
   int count = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i].Length<=3)
      {
         newArray[count] = array[i];
         count++;
      }
   }
   return newArray;
}

Console.Write("Введите длинну массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = FillArray(n);
Console.Write("[");
PrintArray(array);
Console.Write("] → ");
int newSize = FindNewSize(array);
if (newSize==0) Console.WriteLine("[]");
else
{
   string[] newArray = CreateNewArray(array, newSize);
   Console.Write("[");
   PrintArray(newArray);
   Console.Write("]");
}
