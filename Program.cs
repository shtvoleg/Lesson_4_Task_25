// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int xPower(int x, int y)                            //  метод возведения в степень
{
    int result = 1;                                 //  результат
    for (int i=1; i<=y; i++)                        //  в виде цикла (по условиям задачи)
        result *= x;
    return result;
}

Console.Clear();				                    // очистка консоли
Console.WriteLine("Введите основание степени: ");	// запрос основания степени
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите показатель степени: ");  // запрос показателя степени
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a} в степени {b} равно {xPower(a,b)}.");     //  вывод на консоль с вызовом метода