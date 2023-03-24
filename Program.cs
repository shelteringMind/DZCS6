// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
//*/
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


