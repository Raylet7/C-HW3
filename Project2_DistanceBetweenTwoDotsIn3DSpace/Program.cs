// Программа, принимающая координаты двух точек
// и вычисляющая расстояние между ними в 3D пространстве
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5,0); B (1,-1,9) -> 11.53
double Distance (int[] dotA, int[] dotB)
{
return Math.Sqrt(Math.Pow(dotA[0] - dotB[0], 2) + Math.Pow(dotA[1] - dotB[1], 2) + Math.Pow(dotA[2] - dotB[2], 2));
}
int[] dotA = new int [3];
int[] dotB = new int [3];
Console.WriteLine("Программа вычисления расстояния между двумя точками в 3D пространстве.");
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
Console.WriteLine("Расстояние между точками А и В равно: " + Math.Round(Distance(dotA, dotB), 2));