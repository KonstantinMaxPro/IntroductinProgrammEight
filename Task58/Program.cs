int[,] GetMatrix(int rows, int columns, int min = 1, int max = 10)
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
int[,] ProductMatrix(int[,] fFactor, int[,] sFactor)
{
    int[,] product = new int[fFactor.GetLength(0),fFactor.GetLength(1)];
    for (int i = 0; i < fFactor.GetLength(0); i++)
    {
        for (int j = 0; j < fFactor.GetLength(1); j++)
        {
            product[i,j] = fFactor[i,j] * sFactor[i,j];
        }
    }
    return product;
}



int rows = 0;
int columns = 0;
//Изменяемые вручную строки в программе
string intError = "ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n";
string programmName = "|  ПРОИЗВЕДЕНИЕ ДВУХ ДВУМЕРНЫХ МАССИВОВ  |";
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
int[,] firstFactor = GetMatrix(rows, columns);
int[,] secondFactor = GetMatrix(rows, columns);
Console.WriteLine($"\nСгенерирован двумерный массив [{rows},{columns}]\nсо случайными числами от 1 до 9");
Console.WriteLine(line);
PrintMatrix(firstFactor);
Console.WriteLine();
PrintMatrix(secondFactor);
int[,] productMatrix = ProductMatrix(firstFactor, secondFactor);
Console.WriteLine(line);
Console.ForegroundColor = ConsoleColor.Yellow;
PrintMatrix(productMatrix);
Console.ResetColor();
Console.WriteLine(line);