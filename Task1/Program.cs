// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int Prompt(string message)
{
    System.Console.Write(message);           // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}

int[] CreateArray(int lenght)     // метод(функция) для создания массива
{
    int[] answer = new int[lenght];
    //Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = Prompt($"Введите число {i + 1} > ");
    }
    return answer;
}
void PrintArray(int[] array)                // вывод массива на консоль
{
    System.Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "   ");
    }
    System.Console.WriteLine("]");
    System.Console.WriteLine();
}

int PozitiveNumber(int[] num)
{
    int count = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] > 0) count++;
    }
    return count;
}


int lenght = Prompt("Введите число элементов массива > ");
int[] array = CreateArray(lenght);
PrintArray(array);
int result = PozitiveNumber(array);
System.Console.WriteLine($"В массиве {result} числа больше 0");
