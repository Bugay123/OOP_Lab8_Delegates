namespace Task3;
/*Універсальні делегати
Написати консольний арифметичний калькулятор для операцій +,-
,*,/. Кожну операцію реалізувати окремим методом та викликати їх за
допомогою універсального делегату. Забезпечити роботу з цілими та
дійсними числами.*/

class Program
{
    delegate T Calc<T>(T a, T b);
    static int Add(int a, int b)
    { return a + b; }
    static int Multiply(int a, int b)
    { return a * b; }
    static int Subtraction(int a, int b)
    { return a - b; }
    static int Division(int a, int b)
    { return a / b; }


    static double Add(double a, double b)
    { return a + b; }
    static double Multiply(double a, double b)
    { return a * b; }
    static double Subtraction(double a, double b)
    { return a - b; }
    static double Division(double a, double b)
    { return a / b; }

    static void Main(string[] args)
    {
        Calc<int> delegateInt = Add;
        int result1 = delegateInt(1, 2);
        Console.WriteLine("Довадання " + result1);
        delegateInt = Multiply;
        result1 = delegateInt(2,1);
        Console.WriteLine("Множення " + result1);
        delegateInt = Subtraction;
        result1 = delegateInt(5, 5);
        Console.WriteLine("Віднімання " + result1);
        delegateInt = Division;
        Console.WriteLine("Ділення " + result1);

        Calc<double> delegateDouble = Add;
        double result2 = delegateDouble(1.1, 2.2);
        Console.WriteLine("Довадання " + result2);
        delegateDouble = Multiply;
        result2 = delegateDouble(2.3, 1.5);
        Console.WriteLine("Множення " + result2);
        delegateDouble = Subtraction;
        result2 = delegateDouble(5.3, 5.4);
        Console.WriteLine("Віднімання " + result2);
        delegateDouble = Division;
        result2 = delegateDouble(5.4, 5.1);
        Console.WriteLine("Ділення " + result2);
    }
}

