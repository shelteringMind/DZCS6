// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
/*/
void CheckNaturalNuber()
{

    Console.Write("Введите последовательность чисел через ';': ");
    string[] numbers = Console.ReadLine()!.Split(";");

    if (! String.IsNullOrEmpty(numbers[0])) {

        int count = 0;
        int nums = 0;
        int iter = 0;

        for (; iter < numbers.Length; iter++) {

            if (int.TryParse(numbers[iter], out nums)) {
                count += nums > 0 ? 1 : 0;
            } else {
                Console.WriteLine("К сожалению, Вы ввели некорректные данные! Программа завершает свою работу...");
                return;
                }
            Console.WriteLine($"Количество натуральных чисел в последовательности составляет: {count}");
        }
    } else {
        Console.WriteLine("К сожалению, Вы не ввели необходимые данные! Программа завершает свою работу...");
        }
}

CheckNaturalNuber();
//*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
//*/
void IntersectionPoint()
{
    Console.WriteLine("Введите параметры двух прямых для определения точки их пересечения на плоскости...");

    Console.Write("Введите k1: ");
    double k1 = double.Parse(Console.ReadLine()!);
    Console.Write("Введите k2: ");
    double k2 = double.Parse(Console.ReadLine()!);
    Console.Write("Введите b1: ");
    double b1 = double.Parse(Console.ReadLine()!);
    Console.Write("Введите b2: ");
    double b2 = double.Parse(Console.ReadLine()!);

    if(k1 != k2) {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.Write($"Прямые пересекаются в точке (x,y): ( {x} , {y} )");
    } else {
        Console.Write($"Прямые параллельны! Они не пересекаются на плоскости...");
        }
}

IntersectionPoint();
//*/