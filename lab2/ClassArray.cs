using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class ClassArray<T> where T : IAnimals
    {
        private T[] cells;

        private T defaultValue;
        public ClassArray(int size, T defVal)
        {
            defaultValue = defVal;
            cells = new T[size];
            for (int i = 0; i < cells.Length; i++)
            {
                cells[i] = defaultValue;
            }
        }

        public static int operator +(ClassArray<T> c, T shark)
        {
            for (int i = 0; i < c.cells.Length; i++)
            {
                if (c.ChekFreeCell(i))
                {
                    c.cells[i] = shark;
                    return i;
                }
            }
            return -1;
        }

        public static T operator -(ClassArray<T> c, int index)
        {
            if (!c.ChekFreeCell(index))
            {
                T shark = c.cells[index];
                c.cells[index] = c.defaultValue;
                return shark;
            }
            return c.defaultValue;
        }

        private bool ChekFreeCell(int index)
        {
            if (index < 0 || index > cells.Length)
            {
                return false;
            }
            if (cells[index] == null)
            {
                return true;
            }
            if (cells[index].Equals(defaultValue))
            {
                return true;
            }
            return false;
        }

        public T getObject(int ind)
        {
            if (ind > -1 && ind < cells.Length)
            {
                return cells[ind];
            }
            return defaultValue;
        }
    }
}
