// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int Prompt(string message)
{
    System.Console.Write(message);           // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}

// y = kx + b

void IntersectionPoint(double k1, double k2, double b1, double b2)
{
    if (k1 == k2 && b1 == b2) System.Console.WriteLine("Эти прямые совпадают");
    if (k1 == k2) System.Console.WriteLine("Эти прямые параллельны");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        System.Console.WriteLine($"Точка пересечения ({x}, {y})");
    }
    }
double k1 = Prompt("Введите значение k1 = ");
double b1 = Prompt("Введите значение b1 = ");
double k2 = Prompt("Введите значение k2 = ");
double b2 = Prompt("Введите значение b2 = ");
IntersectionPoint(k1, k2, b1, b2);
