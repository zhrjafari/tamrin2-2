using System;

class determinan
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[3, 3];

        Console.WriteLine("Enter the elements of the matrix:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int determinan = GetDeterminan(matrix);
        Console.WriteLine("The determinan of the matrix is: " + determinan);

        int[,] inverseMatrix = GetInverseMatrix(matrix);
        Console.WriteLine("The inverse matrix is:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(inverseMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int GetDeterminan(int[,] matrix)
    {
        int determinan = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])
                         - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
                         + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
        return determinan;
    }

    static int[,] GetInverseMatrix(int[,] matrix)
    {
        int determinan = GetDeterminan(matrix);

        int[,] inverseMatrix = new int[3, 3];
        inverseMatrix[0, 0] = (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) / determinan;
        inverseMatrix[0, 1] = -(matrix[0, 1] * matrix[2, 2] - matrix[0, 2] * matrix[2, 1]) / determinan;
        inverseMatrix[0, 2] = (matrix[0, 1] * matrix[1, 2] - matrix[0, 2] * matrix[1, 1]) / determinan;
        inverseMatrix[1, 0] = -(matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]) / determinan;
        inverseMatrix[1, 1] = (matrix[0, 0] * matrix[2, 2] - matrix[0, 2] * matrix[2, 0]) / determinan;
        inverseMatrix[1, 2] = -(matrix[0, 0] * matrix[1, 2] - matrix[0, 2] * matrix[1, 0]) / determinan;
        inverseMatrix[2, 0] = (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]) / determinan;
        inverseMatrix[2, 1] = -(matrix[0, 0] * matrix[2, 1] - matrix[0, 1] * matrix[2, 0]) / determinan;
        inverseMatrix[2, 2] = (matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]) / determinan;

        return inverseMatrix;
    }
}
