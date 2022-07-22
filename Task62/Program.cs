int[,] GetMatrix(int size)
{
    int[,] matrix = new int[size, size];
    int value = 1;
    int i = 0, j = 0, n = matrix.GetLength(1);
    while (n != 0)
    {
        for (int k = 0; k < n - 1; k++)
        {
            matrix[i, j++] = value++;
        }
        for (int k = 0; k < n - 1; k++)
        {
            matrix[i++, j] = value++;
        }
        for (int k = 0; k < n - 1; k++)
        {
            matrix[i, j--] = value++;
        }
        for (int k = 0; k < n - 1; k++)
        {
            matrix[i--, j] = value++;
        }
        if (matrix[n / 2, n / 2] == 0)
        {
            matrix[n / 2, n / 2] = n * n;
        }
        n = n < 2 ? 0 : n - 2;
        ++i; ++j;
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int size = 0;
string programmName = "|  ГЕНЕРАЦИЯ ЧИСЕЛ В ДВУМЕРНОЙ МАТРИЦЕ ПО СПИРАЛИ  |";
string line = new string('=', programmName.Length);
string intError = "ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n";
string inputMessage1 = "Введите размер квадратного двумерного массива: ";


Console.Clear();//Очищаем консоль
/*ЗАГОЛОВОК (ДЛЯ КРАСОТЫ)*/
Console.WriteLine($"{line}\n{programmName}\n{line}\n");//Название
/*КОНЕЦ ЗАГОЛОВКА*/

Console.Write(inputMessage1);
while (!int.TryParse(Console.ReadLine(), out size))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(intError);
    Console.ResetColor();
    Console.Write(inputMessage1);
}

Console.Clear();//Очищаем консоль
/*ЗАГОЛОВОК (ДЛЯ КРАСОТЫ)*/
Console.WriteLine($"{line}\n{programmName}\n{line}\n");//Название
/*КОНЕЦ ЗАГОЛОВКА*/
Console.WriteLine($" Сгенерирован двумерный массив (матрица) [{size},{size}]");
Console.WriteLine(line);
Console.ForegroundColor = ConsoleColor.Yellow;
PrintMatrix(GetMatrix(size));
Console.ResetColor();
Console.WriteLine(line);
