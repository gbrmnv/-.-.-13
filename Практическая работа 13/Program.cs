namespace Prime
{

    class Program
    {
        static void Matrix1to256(int[,] Matrix, double chislo)
        {
            double[,] q = new double[Matrix.GetLength(0), Matrix.GetLength(1)];

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    q[i, j] = Matrix[i, j] * chislo;
                    Console.Write(q[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] q = new int[4, 4];
            Random rnd = new Random();
            int max = 0;
            int count = 0;
            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    q[i, j] = rnd.Next(-20, 20);
                    Console.Write(q[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (q[i, j] > max) max = q[i, j];
                    if (i + j == 3) count += q[i, j];
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (q[i, j] == max) q[i, j] = count;
                }
            }
            Console.WriteLine("максимальный элемент в k-том столбце равен: " + max);
            Console.WriteLine("После умножения");
            Matrix1to256(q, max);
            Console.ReadKey();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sum = q[i, j] * max;
                    Console.Write(sum + "\t");

                }

                Console.WriteLine();
                Console.ReadKey();

            }
        }
    }
}

