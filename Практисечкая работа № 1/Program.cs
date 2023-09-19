using System;

class Program
{
    static void Main()
    {
        int choice;
        double num1, num2, result;

        do
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложить 2 числа");
            Console.WriteLine("2. Вычесть первое из второго");
            Console.WriteLine("3. Перемножить два числа");
            Console.WriteLine("4. Разделить первое на второе");
            Console.WriteLine("5. Возвести в степень N первое число");
            Console.WriteLine("6. Найти квадратный корень из числа");
            Console.WriteLine("7. Найти 1 процент от числа");
            Console.WriteLine("8. Найти факториал из числа");
            Console.WriteLine("9. Выйти из программы");

            // Ввод операции
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Введите первое число: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = double.Parse(Console.ReadLine());
                    result = num1 + num2;
                    Console.WriteLine($"Результат: {result}");
                    break;
                case 2:
                    Console.Write("Введите первое число: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = double.Parse(Console.ReadLine());
                    result = num1 - num2;
                    Console.WriteLine($"Результат: {result}");
                    break;
                case 3:
                    Console.Write("Введите первое число: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = double.Parse(Console.ReadLine());
                    result = num1 * num2;
                    Console.WriteLine($"Результат: {result}");
                    break;
                case 4:
                    Console.Write("Введите первое число: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = double.Parse(Console.ReadLine());
                    if (num2 == 0)
                    {
                        Console.WriteLine("Ошибка: деление на ноль");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Результат: {result}");
                    }
                    break;
                case 5:
                    Console.Write("Введите число: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Введите степень: ");
                    int power = int.Parse(Console.ReadLine());
                    result = Math.Pow(num1, power);
                    Console.WriteLine($"Результат: {result}");
                    break;
                case 6:
                    Console.Write("Введите число: ");
                    num1 = double.Parse(Console.ReadLine());
                    if (num1 < 0)
                    {
                        Console.WriteLine("Ошибка: извлечение квадратного корня из отрицательного числа");
                    }
                    else
                    {
                        result = Math.Sqrt(num1);
                        Console.WriteLine($"Результат: {result}");
                    }
                    break;
                case 7:
                    Console.Write("Введите число: ");
                    num1 = double.Parse(Console.ReadLine());  //parse строковое значение в число
                    result = num1 / 100;
                    Console.WriteLine($"1 процент от числа: {result}");
                    break;
                case 8:
                    Console.Write("Введите число: ");
                    num1 = double.Parse(Console.ReadLine());
                    result = Factorial(num1);
                    Console.WriteLine($"Факториал числа: {result}");
                    break;
                case 9:
                    Console.WriteLine("Выход из программы.");
                    break;
                default:
                    Console.WriteLine("Ошибка: неверный номер операции");
                    break;
            }
        } while (choice != 9);
    }

    // Рекурсивная функция для вычисления факториала
    static double Factorial(double n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }
}

