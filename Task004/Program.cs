// Напишите программу, которая принимает на вход
// число (N) и выдает произведение чисел от 1 до (N)

// 4 -> 24
// 5 -> 120

// Вариант 2

int GetInfo(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

int number = GetInfo("Введите число: ");
int faktorial = 1;
while (number > 0)
{
    faktorial = faktorial * number; // faktorial = 1 * 5 
    number--;  // number = 5-1 и повторяем теже действия до тех пор пока number не станет 0, после выводим результат 
}
Console.WriteLine(faktorial);