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

            float a = 1.0F;
            for (int x = 0; x < m.RowLength; x++)
            {
                for (int y = 0; y < m.ColLength; y++)
                {
                    //m[x, y] = a;
                    //a += 1.0F;
                    m[x, y] = 0.0F;

                    Console.Write("{0} ", m[x, y]);
                }
                Console.WriteLine();
            }



            for (int y = 0; y < m.ColLength; y++)
            {
                for (int x = 0; x < m.RowLength; x++)
                {
                    Console.WriteLine("[{0}, {1}] = {2}", x, y, m.GetValue(x, y, input[x,y]));
                }
            }


            float[,] training_data = new float[,] { { 0.0f, 0.0f }, { 1.0f, 0.0f }, { 2.0f, 0.0f }, { 2.5f, 0.0f }, { 3.0f, 1.0f }, { 4.0f, 1.0f }, { 5.0f, 1.0f } };

            for (int j = 0; j < 10; j++)
            {
                m[1, 1] += 0.5f;

                float error = 0.0f;
                for (int i = 0; i < training_data.GetLength(0); i++)
                {
                    float[,] train_matrix = new float[2, 3];
                    train_matrix[1, 1] = training_data[i, 0];

                    float y = m.GetValue(1, 1, train_matrix[1,1]);

                    Console.WriteLine("{0} -> {1} : {2}", training_data[i, 0], training_data[i, 1], y);

                    error += Math.Abs(y - training_data[i, 1]);
                }

                Console.WriteLine("error = {0}", error);

                if (error < 0.5f)
                {
                    break;
                }
            }

            Console.WriteLine("optimized = {0}", m[1, 1]);


            Console.WriteLine("(row, col) = ({0}, {1})", m.RowLength, m.ColLength);


            float[,] m2 = new float[3, 2];
            m2[0, 0] = 1;
            m2[0, 1] = 2;
            
            m2[1, 0] = 3;
            m2[1, 1] = 4;

            m2[2, 0] = 15;
            m2[2, 1] = 6;

            m[1, 1] = 5;

            float[,] t = m.Assignment(m2);

         
            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int j = 0; j < t.GetLength(1); j++)
                {
                    Console.Write("{0} ", t[i, j]);
                }

                Console.WriteLine();
            }

        }
    }
}
