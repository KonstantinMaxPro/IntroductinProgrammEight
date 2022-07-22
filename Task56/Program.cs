int[,] GetMatrix(int rows, int columns, int min = 0, int max = 10)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
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

int[] GetSumStringMatrix(int[,] matrix)
{
    int[] sum = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum[i] += matrix[i, j];
        }
    }
    return sum;
}

void PrintMinSumStringMatrix(int[] sum)
{
    int min = sum[0];
    int numString = 0;
    for (int i = 0; i < sum.Length; i++)
    {
        Console.WriteLine($"{i + 1} строка с суммой {sum[i]}");//Делаем нумерацию строки для удобства пользователя i + 1
        if (min > sum[i])
        {
            min = sum[i];
            numString = i;
        }
    }
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write($"\nНаименьшая сумма \"{min}\" в строке \"{numString + 1}\"");//Делаем нумерацию строки для удобства пользователя numString + 1
    Console.ResetColor();
}



int rows = 0;
int columns = 0;
//Изменяемые вручную строки в программе
string intError = "ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n";
string programmName = "|  ВЫЧЕСЛЕНИЕ СТРОКИ С НАИМЕНЬШЕЙ СУММОЙ ЗНАЧЕНИЙ  |";
string inputMessage1 = "Введите количество строк в массиве: ";
string inputMessage2 = "Введите количество столбцов в массиве: ";

Console.Clear();
string line = new string('=', programmName.Length);
Console.WriteLine($"{line}\n{programmName}\n{line}\n");//Название

Console.Write(inputMessage1);
while (!int.TryParse(Console.ReadLine(), out rows))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(intError);
    Console.ResetColor();
    Console.Write(inputMessage1);
}
Console.Write(inputMessage2);
while (!int.TryParse(Console.ReadLine(), out columns))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(intError);
    Console.ResetColor();
    Console.Write(inputMessage2);
}
int[,] result = GetMatrix(rows, columns);

Console.WriteLine($"\nСгенерирован двумерный массив [{rows},{columns}]");
Console.WriteLine(line);
PrintMatrix(result);
int[] sumStringMatrix = GetSumStringMatrix(result);
Console.WriteLine(line);
PrintMinSumStringMatrix(sumStringMatrix);
Console.WriteLine("\n" + line);