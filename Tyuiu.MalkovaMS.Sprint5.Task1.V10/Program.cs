using Tyuiu.MalkovaMS.Sprint5.Task1.V10.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int startValue = -5;
        int stopValue = 5;
        Console.Title = "Спринт #5 | Выполнила: Малькова М. С. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");

        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #10                                                             *");
        Console.WriteLine("* Выполнила: Малькова Мария Сергеевна | ИИПб-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дана функция, произвести табулирование на заданном диапазоне [-5;5]     *");
        Console.WriteLine("* с шагом 1.                                                              *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("    2cos(x)+2                                                              ");
        Console.WriteLine("y = --------- + cos(x) - 5x + 3                                            ");
        Console.WriteLine("       2x-1                                                                ");
        Console.WriteLine();
        Console.WriteLine("startValue = " + startValue);
        Console.WriteLine("stopValue = " + stopValue);
        Console.WriteLine("***************************************************************************");
        string res = ds.SaveToFileTextData(startValue, stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine($"Файл {res} создан!");
        Console.ReadKey();
    }
}