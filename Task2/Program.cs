namespace Task2;

/*Групове перетворення методів, що делегуються
Написати програму, яка в залежності від порядкового номера місяця
(1,2,...12) виводить на екран його назву (січень,...грудень) та середню
температуру місяця. Дані про температуру місяця зберігаються в
масивах (або одному двовимірному масиві). Реалізувати 3 методи для
довільних 3 місяців та використати групове перетворення методів, що
делегуються.*/


class Program
{
    delegate void Del();
    static double GetMas(int[] mas, int t1, int t2)
    {
        double sum = 0;
        Random random = new Random();
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = random.Next(t1, t2);
            sum += mas[i];
        }
        double avg = (double)Math.Round((sum / mas.Length), 2);
        return avg;
    }

    static void January()
    {
        int[] mas = new int[31];
        double avg = GetMas(mas, -25, 5);
        Console.WriteLine($"Середня температура у січні = {avg}");
    }
    static void February()
    {
        int[] mas = new int[28];
        double avg = GetMas(mas, -20, 1);
        Console.WriteLine($"Середня температура у лютому = {avg}");
    }
    static void March()
    {
        int[] mas = new int[31];
        double avg = GetMas(mas, -10, 10);
        Console.WriteLine($"Середня температура у березні = {avg}");
    }

    static void Error()
    {
        Console.WriteLine("Помилка! Потрібно ввести число від 1 до 3");
    }
    static void Main(string[] args)
    {
        Del month;
        int x = int.Parse(Console.ReadLine());
        switch (x)
        {
            case 1:
                {
                    month = January;
                    break;
                }
            case 2:
                {
                    month = February;
                    break;
                }
            case 3:
                {
                    month = March;
                    break;
                }
            default:
                {
                    month = Error;
                    break;
                }
        }
        month();
    }
}

