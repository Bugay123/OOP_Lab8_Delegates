namespace Task1;

/*Просте використання делегатів
Написати програму обчислення значень функції у заданій точці x.
Значення x вводиться з консолі. Результат вивести на консоль.
Функція F задається таким чином:
F(x) = x^2 +4 , x>0,
F(x)=0, x<=0
Якщо нічого не введено – вивести повідомлення “Потрібно було
ввести число” і завершити роботу.
Кожна функція реалізується окремим методом. Вибір методу
делегату виконується при виконанні.
 */

public delegate double Del(double x);
class Program
{
    static double F1(double x)
    {
        return Math.Pow(x, 2) + 4;
    }
    static double F2(double x)
    {
        return 0;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введіть число: ");
        double x = int.Parse(Console.ReadLine());
        Del del = null;
        if (!double.TryParse(Console.ReadLine(), out double x))
        {
            Console.WriteLine("Потрібно було ввести число");
            return;
        }
        Del del = null;
        if (x > 0) { del = new Del(F1); }
        else { del = new Del(F2); }
        double fun = del(x);
        Console.WriteLine($"При x = {x}, F(x) = {fun}");
    }
}