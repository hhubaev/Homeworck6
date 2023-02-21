// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
int DataEntry(string message)                           //Метод ввода данных
{
	Console.Write(message);
	return Convert.ToInt32(Console.ReadLine());
}
string StringEntry(string message)
{
	Console.Write(message);
	return Console.ReadLine();
}
void FillArray(string[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = StringEntry($"Введите {i+1}-й элемент массива ");
	}
}

int sizeArray = 0;
sizeArray = DataEntry("Введите размер массива ");
string[] sourceArray = new string[sizeArray];
string[] finalArray = new string[sizeArray];
FillArray(sourceArray);
int j = 0;
for (int i = 0; i < sourceArray.Length; i++)
{
	if(sourceArray[i].Length<3)
	{
		finalArray[j] = sourceArray[i];
		j++;
	}

}
Array.Resize(ref finalArray, j);
System.Console.WriteLine("[{0}]", string.Join(", ", sourceArray));
System.Console.WriteLine("[{0}]", string.Join(", ", finalArray));