/*
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

int countSymbol = 3;
Console.WriteLine("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите {size} слов(а): ");

string[] firstArray = new string[size];

GetArray(firstArray);
Console.WriteLine();
Console.WriteLine("Имеющийся массив строк: ");
PrintArray(firstArray);
if (SizeSecondArray(firstArray) == 0)
{
  Console.WriteLine();
  Console.WriteLine("Слов длина которых меньше, либо равна 3 символам не найдено!");
}
else
{
  string[] secondArray = TransferArray(firstArray);
  Console.WriteLine();
  Console.WriteLine("Новый массив из строк, длина которых меньше, либо равна 3 символам: ");
  PrintArray(secondArray);
}


void GetArray(string[] array)
{
  for (int i = 0; i < size; i++)
  {
    array[i] = Console.ReadLine();
  }
}


void PrintArray(string[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + "; ");
  }
  Console.WriteLine();
}


int SizeSecondArray(string[] array)
{
  int secondSize = 0;
  for (int i = 0; i < size; i++)
  {
    if (array[i].Length <= countSymbol)
    {
      secondSize++;
    }
  }
  return secondSize;
}


string[] TransferArray(string[] array)
{
  string[] secondArray = new string[SizeSecondArray(firstArray)];
    for (int i = 0, j = 0; i < size; i++)
  {
    if (array[i].Length <= countSymbol)
    {
      secondArray[j] = array[i];
      j++;
    }
  }
  return secondArray;
}