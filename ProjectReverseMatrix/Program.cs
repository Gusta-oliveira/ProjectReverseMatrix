int[,] matrix = new int[4, 4];
int[,] matrix2 = new int[4, 4];

Random aleatorio = new Random();
//Atribuindo valores a matrix de forma aleatória
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for (int c = 0; c < matrix.GetLength(1); c++)
    {
        matrix[i, c] = aleatorio.Next(1000); 
    }
}
//Transferindo valores na matriz 2 de forma inversa
for(int i = 0;i < matrix2.GetLength(0); i++)
{
    for(int c = 0; c< matrix2.GetLength(1); c++)
    {
        matrix2[i, c] = matrix[matrix.GetLength(0) - 1 - i, matrix.GetLength(1) - 1 -c];
    }
}
//Impressao matriz 1
Console.WriteLine("Matrix 1");
for (int line = 0; line < matrix.GetLength(0); line++)
{
    for (int column = 0; column < matrix.GetLength(1); column++)
    {
        Console.Write("|\t" + matrix[line, column]);
    }
    Console.WriteLine("\t|");
}
//Impressao da matriz 2
Console.WriteLine("Matrix 2");
for (int line = 0; line < matrix.GetLength(0); line++)
{
    for (int column = 0; column < matrix.GetLength(1); column++)
    {
        Console.Write(" | " + matrix2[line, column]);
    }
    Console.WriteLine(" |");
}