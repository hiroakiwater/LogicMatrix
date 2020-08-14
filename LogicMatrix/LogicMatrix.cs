﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Text;

namespace LogicMatrix
{
    class LogicMatrix
    {
        private float[,] m;
        public Func<float, float, float>[,] logics;

        public float this[int i, int j]
        {
            set
            {
                this.m[i, j] = value;
            }

            get
            {
                return this.m[i, j];
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

            this.logics = new Func<float, float, float>[row, col];

            for (int j = 0; j < col; j++)
            {
                for (int i = 0; i < row; i++)
                {
                    this.m[i, j] = 0.0F;
                    this.logics[i, j] = (x, y) => 0;
                }
            }
        }        

        public float SetGradient(float[,] x, float[,] y)
        {
            for (int j = 0; j < ColLength; j++)
            {
                for (int i = 0; i < RowLength; i++)
                {

                }
            }

            return 0.0F;
        }

        public float GetValue(int i, int j, float[,] x)
        {
            return this.logics[i, j](m[i, j], x[i, j]);
        }
    }
}
