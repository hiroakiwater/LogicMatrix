using System;

namespace LogicMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            LogicMatrix m = new LogicMatrix(2, 3);

            float[,] input = new float[2, 3];
            input[0, 0] = 0.0F;
            input[0, 1] = 0.0F;
            input[0, 2] = 0.0F;

            input[1, 0] = 0.0F;
            input[1, 1] = 3.0F;
            input[1, 2] = 0.0F;


            m.logics[1, 1] = (m, x) =>
            {
                if (x > m)
                {
                    return 1.0F;
                }
                else
                {
                    return 0.0F;
                }
            };

            for (int y = 0; y < m.ColLength; y++)
            {
                for (int x = 0; x < m.RowLength; x++)
                {
                    m[x, y] = 1;
                }
            }

            for (int y = 0; y < m.ColLength; y++)
            {
                for (int x = 0; x < m.RowLength; x++)
                {
                    Console.WriteLine("[{0}, {1}] = {2}", x, y, m.GetValue(x, y, input));
                }
            }

            Console.WriteLine("(row, col) = ({0}, {1})", m.RowLength, m.ColLength);
        }
    }
}
