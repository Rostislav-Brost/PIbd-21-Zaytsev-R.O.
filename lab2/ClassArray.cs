using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class ClassArray<T> where T : IAnimals
    {
        //4
        private Dictionary<int, T> cells;
        private int maxCount;
        //

        private T defaultValue;
        public ClassArray(int size, T defVal)
        {
            defaultValue = defVal;
            //4
            cells = new Dictionary<int, T>();
            maxCount = size;
            //
        }

        public static int operator +(ClassArray<T> c, T shark)
        {  //4
            if (c.cells.Count == c.maxCount)
            {
                return -1;
            }
            //
            for (int i = 0; i < c.cells.Count; i++)
            {
                if (c.ChekFreeCell(i))
                {
                    //4
                    c.cells.Add(i, shark);
                    //
                    return i;
                }
            }
            //4
            c.cells.Add(c.cells.Count, shark);
            return c.cells.Count - 1;
            //
        }

        public static T operator -(ClassArray<T> c, int index)
        {
            //4
            if (c.cells.ContainsKey(index))
            {
                T shark = c.cells[index];
                c.cells.Remove(index);
                return shark;
            }
            //
            return c.defaultValue;
        }

        private bool ChekFreeCell(int index)
        {
            //4
            return !cells.ContainsKey(index);
            //
        }
        //4 
        public T this[int ind]
        {
            get
            {
                if (cells.ContainsKey(ind))
                {
                    return cells[ind];
                }
                return defaultValue;
            }
        }
        //
        public T getObject(int ind)
        {
            if (ind > -1 && ind < cells.Count)
            {
                return cells[ind];
            }
            return defaultValue;
        }
    }
}
