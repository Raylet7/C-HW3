// Программа, принимающая на вход число N
// и выдающая таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
int GetCube(int number)
{
    int cube = number * number * number;
    return cube;
}
Console.WriteLine("Программа, выдающая таблицу кубов чисел от 1 до N.");
Console.WriteLine("Введите число N: ");
int number = int.Parse(Console.ReadLine()!);
int[] array = new int[number];
void PrintArray(int[] array)
{
    int count = array.Length;
    number = number + 1;
    for(int i = 0; i < count; i++)
    {
        Console.WriteLine(number + " ^ 3 = " + array[i]);
        number++;
    }
    Console.WriteLine();
}
while(number > 0)
{
    array[number - 1] = GetCube(number);
    number = number - 1;
}
PrintArray(array);