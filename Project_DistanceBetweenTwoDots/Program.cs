// Программа вычисления расстояния между двумя точками в N-мерном пространстве. 
// Сначала ввод N с клавиатуры, затем ввод координат точек.
double DistanceIn2DSpace(int[] dotA, int[] dotB)
{
    return Math.Sqrt(Math.Pow(dotB[0] - dotA[0], 2) + Math.Pow(dotB[1] - dotA[1], 2));
}
double DistanceIn3DSpace(int[] dotA, int[] dotB)
{
    return Math.Sqrt(Math.Pow(dotB[0] - dotA[0], 2) + Math.Pow(dotB[1] - dotA[1], 2) + Math.Pow(dotB[2] - dotA[2], 2));
}
Console.WriteLine("Программа вычисления расстояния между двумя точками в N-мерном пространстве.");
Console.WriteLine("Введите мерность пространства. Значение N равно: ");
int nDSpace = int.Parse(Console.ReadLine()!);
if (nDSpace == 1)
{
    Console.WriteLine("Введите координату Х для точки А. Значение Х равно: ");
    int dotA = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите координату Х для точки B. Значение Х равно: ");
    int dotB = int.Parse(Console.ReadLine()!);
    int result = dotB - dotA;
    if (result < 0)
    {
        result = result * -1;
    }
    Console.WriteLine("Расстояние между точками А и В равно: " + result);
}
if (nDSpace == 2)
{
    int[] dotA = new int[2];
    int[] dotB = new int[2];
    Console.WriteLine("Введите координату Х для точки А. Значение Х равно: ");
    dotA[0] = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите координату Y для точки А. Значение Y равно: ");
    dotA[1] = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите координату Х для точки B. Значение Х равно: ");
    dotB[0] = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите координату Y для точки B. Значение Y равно: ");
    dotB[1] = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Расстояние между точками А и В равно: " + Math.Round(DistanceIn2DSpace(dotA, dotB), 2));
}
if (nDSpace == 3)
{
    int[] dotA = new int[3];
    int[] dotB = new int[3];
    Console.WriteLine("Введите координату Х для точки А. Значение Х равно: ");
    dotA[0] = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите координату Y для точки А. Значение Y равно: ");
    dotA[1] = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите координату Z для точки А. Значение Z равно: ");
    dotA[2] = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите координату Х для точки B. Значение Х равно: ");
    dotB[0] = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите координату Y для точки B. Значение Y равно: ");
    dotB[1] = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите координату Z для точки B. Значение Z равно: ");
    dotB[2] = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Расстояние между точками А и В равно: " + Math.Round(DistanceIn3DSpace(dotA, dotB), 2));
}
if (nDSpace > 3)
{
    Console.WriteLine("Неверный ввод");
}