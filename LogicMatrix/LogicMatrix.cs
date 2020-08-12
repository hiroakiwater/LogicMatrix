using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LogicMatrix
{
    class LogicMatrix
    {
        private float[,] m;
        public Func<float, float>[,] logics;

        public float this[int i, int j]
        {
            set
            {
                this.m[i, j] = value;
            }

            get
            {
                return logics[i, j](m[i, j]);
            }
        }

        public int RowLength
        {
            get { return this.m.GetLength(0); }
        }

        public int ColLength
        {
            get { return this.m.GetLength(1); }
        }

        public LogicMatrix(int row, int col)
        {
            this.m = new float[row, col];

            this.logics = new Func<float, float>[row, col];

            for (int j = 0; j < col; j++)
            {
                for (int i = 0; i < row; i++)
                {
                    this.logics[i, j] = v => 0;
                }
            }
        }        
    }
}
