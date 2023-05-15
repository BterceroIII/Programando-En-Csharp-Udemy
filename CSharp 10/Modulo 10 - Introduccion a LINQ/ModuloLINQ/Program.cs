using ModuloLINQ;
using System.ComponentModel.DataAnnotations.Schema;



int DiagonalDifference(List<List<int>> arr)
{
    int primarySum = 0;
    int secondarySum = 0;

    for (int i = 0; i < arr.Count; i++)
    {
        primarySum += arr[i][i];
        secondarySum += arr[i][arr.Count - 1 - i];
    }
    int diagonalDifference = Math.Abs(primarySum - secondarySum);
    return diagonalDifference;
}


List<List<int>> matrix = new List<List<int>>()
{
    new List<int> {11, 2, 4 },
    new List<int> {4, 5, 6 },
    new List<int> {10, 8, -12 }
};

int resultado = DiagonalDifference(matrix);
Console.WriteLine(resultado);
