using System;

namespace LogicMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            LogicMatrix m = new LogicMatrix(2, 3);

            m.logics[1, 1] = x =>
            {
                if (x > 5)
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
                    m[x, y] = 10;
                }
            }

            for (int y = 0; y < m.ColLength; y++)
            {
                for (int x = 0; x < m.RowLength; x++)
                {
                    Console.WriteLine("[{0}, {1}] = {2}", x, y, m[x, y]);
                }
            }

            Console.WriteLine("(row, col) = ({0}, {1})", m.RowLength, m.ColLength);
        }
    }
}
