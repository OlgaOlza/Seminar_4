// Напишите программу, которая принимает на вход
// число (N) и выдает произведение чисел от 1 до (N)

// 4 -> 24
// 5 -> 120

int GetMul(int limit)
{
        int mul =1;
        for (int i = 1; i <= limit; i++)
        {
            mul *= i;
        }
        return mul;
 }

int GetInfo (string text)
{
Console.Write(text);
int inputNum = Convert.ToInt32 (Console.ReadLine());
return inputNum;
}

int numberA = GetInfo("Введите число A: ");

 Console.WriteLine($"Произведение всех чисел от 1 до {numberA} равна {GetMul(numberA)}");

