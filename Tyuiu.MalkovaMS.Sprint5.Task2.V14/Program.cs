using Tyuiu.MalkovaMS.Sprint5.Task2.V14.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int[,] matrix = new int[3, 3];
        int rows = 3;
        int columns = 3;
        Console.Title = "Спринт #5 | Выполнила: Малькова М. С. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");

        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #14                                                             *");
        Console.WriteLine("* Выполнила: Малькова Мария Сергеевна | ИИПб-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
        Console.WriteLine("* значениями с клавиатуры. Заменить положительные элементы массива на 1,  *");
        Console.WriteLine("* отрицательные на 0. Результат сохранить в файл и вывести на консоль     *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Введите {i},{j} элемент массива: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{matrix[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("***************************************************************************");
        string res = ds.SaveToFileTextData(matrix);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine($"Файл {res} создан!");
        Console.ReadKey();
    }
}