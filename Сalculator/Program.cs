using System;
using System.Collections.Generic;


namespace Calculator
{
    class Program
    {
        static List<string> history = new List<string>();

        static void Main(string[] args)
        {

            Console.WriteLine("Добро пожаловать в консольный калькулятор!");

            while (true)
            {
                try
                {
                    Console.WriteLine("Введите число 1");
                    double firstvalue = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Выберите операцию ('+' '-' '*' '/')");
                    string op = Console.ReadLine();

                    Console.WriteLine("Введите число 2");
                    double secondvalue = Convert.ToDouble(Console.ReadLine());

                    double result = PerformOperation(firstvalue, op, secondvalue);
                    Console.WriteLine($"Результат: {result}");

                    Console.WriteLine("Введите 'y' для продолжения или любую клавишу для выхода:");
                    string choice = Console.ReadLine();

                    if (choice.ToLower() != "y")
                    {
                        break;
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Возникла ошибка: {ex.Message}");


                }

                Console.WriteLine("История операций:");
                foreach (string operation in history)
                {
                    Console.WriteLine(operation);
                }

                Console.WriteLine("Введите 'clear' для очистки истории или любую клавишу для выхода:");
                string clearChoice = Console.ReadLine();

                if (clearChoice.ToLower() == "clear")
                {
                    history.Clear();
                    Console.WriteLine("История операций очищена.");
                }

            }
        }

        static double PerformOperation(double firstvalue, string op, double secondvalue)
        {
            double result = 0;

            switch (op)
            {
                case "+":
                    result = firstvalue + secondvalue;
                    Console.WriteLine("Результат решения прибавления:" + result);
                    break;

                case "-":
                    result = firstvalue - secondvalue;
                    Console.WriteLine("Результат решения отнимания:" + result);
                    break;

                case "*":
                    result = firstvalue * secondvalue;
                    Console.WriteLine("Результат решения умножения:" + result);
                    break;

                case "/":
                    if (secondvalue == 0)

                        throw new DivideByZeroException("Деление на ноль невозможно.");
    
                    result = firstvalue / secondvalue;
                    
                    break;

                default:

                    throw new ArgumentException("Некорректный оператор.");

            }
            return result;
            

        }
    }
}
    
    