// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Write("Введите число A: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = 1;

for (int i = 0; i < number2; i++)
{
    number3 = number3 * number1;
}
Console.WriteLine($"число A в натуральной степени B: {number3}");

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());
int len = Length(num);


int Length(int num)
{
int index = 0;
while (num > 0)
{
num /= 10;
index++;
}
return index;
}

int Sum(int num, int len)
{
int sum = 0;
for (int i = 1; i <= len; i++)
{
sum += num % 10;
num /= 10;
}
return sum;
}
Console.Write($"Сумма цифр в числе {num} равно: {Sum(num,len)}");


// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// // 6, 1, 33 -> [6, 1, 33]


int[] RandomArray = new int[8];

for (int i = 0; i < 8; i++)
{
RandomArray[i] = new Random().Next(1,99);
Console.Write(RandomArray[i] + " ");
}

