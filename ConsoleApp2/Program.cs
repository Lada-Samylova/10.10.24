using System;
namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nВыберите операцию:");
                Console.WriteLine("1. Присваивание");
                Console.WriteLine("2. Бинарные операции");
                Console.Write("Введите номер операции: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    AssignmentOperation();
                }
                else if (choice == "2")
                {
                    BinaryOperations();
                }
                else
                {
                    Console.WriteLine("Неверный выбор.");
                }
            }
        }
        static void AssignmentOperation()
        {
            Console.Write("Введите число: ");
            string variableName = Console.ReadLine();
            Console.Write("Введите значение для присваивания: ");
            string valueStr = Console.ReadLine();

            if (double.TryParse(valueStr, out double value))
            {
                Console.WriteLine($"{variableName} = {value}");
            }
            else
            {
                Console.WriteLine("Некорректное значение. Введите число.");
            }
        }
        static void BinaryOperations()
        {
            Console.Write("Введите первое число: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nВыберите операцию:");
            Console.WriteLine("1. Сложение (+) ");
            Console.WriteLine("2. Вычитание (-) ");
            Console.WriteLine("3. Умножение (*) ");
            Console.WriteLine("4. Деление (/) ");
            Console.WriteLine("5. Модульное деление (%) ");
            Console.Write("Введите номер операции: ");
            string choice = Console.ReadLine();

            double result = 0;

            switch (choice)
            {
                case "1":
                    result = num1 + num2;
                    break;
                case "2":
                    result = num1 - num2;
                    break;
                case "3":
                    result = num1 * num2;
                    break;
                case "4":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Деление на ноль!");
                    }
                    else
                    {
                        result = num1 / num2;
                    }
                    break;
                case "5":
                    result = num1 % num2;
                    break;
                default:
                    Console.WriteLine("Неверный выбор.");
                    return;
            }

            if (result != 0)
            {
                Console.WriteLine($"{num1} {GetOperator(choice)} {num2} = {result}");
            }
        }
        static string GetOperator(string choice)
        {
            switch (choice)
            {
                case "1": return "+";
                case "2": return "-";
                case "3": return "*";
                case "4": return "/";
                case "5": return "%";
                default: return "";
            }
        }
    }
}