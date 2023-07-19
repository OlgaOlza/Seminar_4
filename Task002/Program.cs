// Напишите программу. которая принмает на вход
// число и выдает количество цифр в числе 
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Вариант 1

// int GetNum (int num)
// {
//     int count = 0;
//     while (num > 0)
//     {
//         num = num / 10;
//         count ++;
//     }
//      return count;
// }

// int GetInfo (string message)
// {
// Console.Write(message);
// return Convert.ToInt32(Console.ReadLine());
// }

// int number = GetInfo("Введите число: ");

// Console.WriteLine($"{number} состоит из {GetNum(number)} цифр ");


// Вариант 2

string GetInfo(string text)
{
    Console.Write(text);
    return Console.ReadLine();
}

string num = GetInfo("Введите число: ");
int lenght = num.lenght;
Console.WriteLine(lenght);