int[,,] GetMatrix(int rows, int columns, int z, int min = 0, int max = 10)
{
    int[,,] matrix = new int[rows, columns, z];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(min, max);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{matrix[i, j, k]} ");
                Console.ResetColor();
                Console.Write($"({i}, {j}, {k})\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
int coub = 0;
string programmName = "|  ГЕНЕРАЦИЯ ТРЁХМЕРНОГО МАССИВА  |";
string line = new string('=', programmName.Length);

Console.Clear();//Очищаем консоль
/*ЗАГОЛОВОК (ДЛЯ КРАСОТЫ)*/
Console.WriteLine($"{line}\n{programmName}\n{line}\n");//Название
/*КОНЕЦ ЗАГОЛОВКА*/


Console.Write("Введите размер трёхмерного массива (куб): ");
while (!int.TryParse(Console.ReadLine(), out coub))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");
    Console.ResetColor();
    Console.Write("Введите размер трёхмерного массива (куб): ");
}

Console.WriteLine($"Сгенерирован трёхмерный массив (матрица) [{coub}, {coub}, {coub}]");
Console.WriteLine(line + "\n");
int[,,] result = GetMatrix(coub, coub, coub);
PrintMatrix(result);
Console.WriteLine(line);
