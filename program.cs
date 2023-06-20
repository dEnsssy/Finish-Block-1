string[] FillArray(int size)
{
   string[] array = new string[size];
   for (int i = 0; i < array.Length; i++)
   {
      array[i] = Console.ReadLine();
   }
   return array;
}

Console.Write("Введите длинну массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = FillArray(n);