// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int InputInt(string? value)
{
    int number = 0;
    while (!int.TryParse(value, out number))
    {
        Console.Write("Введенное выражение не является целым числом. Повторите ввод: ");
        value = Console.ReadLine();
    }
    return number;
}

int[] InputCoor(string pointName)
{
    int[] point = new int[3];
    for (int i = 0; i < 3; i++)
    {
        string axis = (i == 0 ? "x" : i == 1 ? "y" : i == 2 ? "z" : "");
        Console.Write($"Введите координату {axis} точки {pointName}: ");
        point[i] = InputInt(Console.ReadLine());
    }
    return point;
}

int[] pointA = InputCoor("A");
int[] pointB = InputCoor("B");
double lengthAB = Math.Round(Math.Sqrt(Math.Pow(pointA[0] - pointB[0], 2)
                                     + Math.Pow(pointA[1] - pointB[1], 2)
                                     + Math.Pow(pointA[2] - pointB[2], 2)), 2);
Console.WriteLine ($"Рассояние между точками А и В равно: {lengthAB}");


