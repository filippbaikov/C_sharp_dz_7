Console.Clear();

int[,] matr = generateMatrix();
printMatrix(matr);
System.Console.WriteLine();
findElement(matr);
System.Console.WriteLine();
System.Console.WriteLine("сумма по диагонали: " + sumDiagonal(matr));
//-----------------------

int[,] generateMatrix()
{
    int row = setMatrixParametrs("введи количиство строк: ");
    int column = setMatrixParametrs("введи количиство столбиков: ");
    int min = setMatrixParametrs("введи min value: ");
    int max = setMatrixParametrs("введи количиство max value: ");

    int[,] matrix = new int[row, column];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(min, max + 1);

        }
        System.Console.WriteLine();

    }
    return matrix;
}

void printMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
int setMatrixParametrs(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void findElement(int[,] matrix)
{
    int row = setMatrixParametrs("введи значение по Х: ");
    int column = setMatrixParametrs("введи значение по Y: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

        }

    }
    System.Console.WriteLine("элемент: ");
    System.Console.WriteLine(matrix[row, column]);
}

int sumDiagonal(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + matrix[i, j];
            }
        }
    }
    return sum;

}