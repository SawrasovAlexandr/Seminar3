// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

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

Console.Write("Введите пятизначное число: ");
int num = InputInt(Console.ReadLine());
if (num > 9999 && num < 100000)
{
    int digit1 = num / 10000,
        digit2 = num / 1000 % 10,
        digit4 = num / 10 % 10,
        digit5 = num % 10;
    Console.Write(digit1 == digit5 && digit2 == digit4 ? "Является полиндромом" : "Не является полиндромом");
}
else Console.Write("Введенное выражение не является пятизначным числом");




//Принимает на вход строку и проверяет является ли она полиндромом

// Console.WriteLine("Введите предположительный палиндром:");
// string palindrom = Console.ReadLine().ToLower();
// int a = 0;
// int z = palindrom.Length - 1;
// bool check = true;
// while (a < z && check)
// {
//     if (palindrom[a] == palindrom[z])
//     {
//         a++;
//         z--;
//     }
//     else
//     {
//         check = false;
//     }
// }
// Console.WriteLine(check ? "Да! Это палиндром!" : "Нет. Это не палиндром.");