
// Написать программу преобразования десятичного числа в двоичное
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int remains = 0;
int count = 0;
int temp = number;

while (temp > 0)
{
temp = temp / 2;
count++;
}

int[] array = new int[count];

for (int i = 0; i < array.Length; i++)
{
remains = number % 2;
array[array.Length - 1 - i] = remains;
number = number / 2;
}

Console.Write(String.Join("", array));