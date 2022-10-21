// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9. 
// 5 -> 1, 8, 27, 64, 125

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

int userN = 0;
double cube = 0;
while (userN < 1)
{
    Console.Write("Введите целое число больше 1: ");
    userN = InputInt(Console.ReadLine());
}
Console.Write($"Последовательность кубов чисел в интревале от 1 до {userN}: ");
for (int i = 1; i < userN; i++)
{
    cube = Math.Pow(i, 3);
    Console.Write(cube + ", ");
}
Console.WriteLine(Math.Pow(userN, 3));