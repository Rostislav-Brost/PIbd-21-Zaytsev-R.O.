using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class ClassArray<T> : IEnumerator<T>, IEnumerable<T>, IComparable<ClassArray<T>>
    {
        //8
        private int currentIndex;
        public T Current
        {
            get
            {
                return cells[cells.Keys.ToList()[currentIndex]];

            }
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public void Dispose()
        {

        }
        public bool MoveNext()
        {
            if (currentIndex + 1 >= cells.Count)
            {
                Reset();
                return false;
            }
            currentIndex++;
            return true;
        }
        public void Reset()
        {
            currentIndex = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        public int CompareTo(ClassArray<T> other)
        {
            if (this.Count() > other.Count())
            {
                return -1;
            }
            else if (this.Count() < other.Count())
            {
                return 1;
            }
            else
            {
                var thisKeys = this.cells.Keys.ToList();
                var otherKeys = other.cells.Keys.ToList();
                for (int i = 0; i < this.cells.Count; ++i)
                {
                    if (this.cells[thisKeys[i]] is Shark && other.cells[thisKeys[i]] is TigerShark)
                    {
                        return 1;
                    }
                    if (this.cells[thisKeys[i]] is TigerShark && other.cells[thisKeys[i]] is Shark)
                    {
                        return -1;
                    }
                    if (this.cells[thisKeys[i]] is Shark && other.cells[thisKeys[i]] is Shark)
                    {
                        return (this.cells[thisKeys[i]] is Shark).CompareTo(other.cells[thisKeys[i]] is Shark);
                    }
                    if (this.cells[thisKeys[i]] is TigerShark && other.cells[thisKeys[i]] is TigerShark)
                    {
                        return (this.cells[thisKeys[i]] is TigerShark).CompareTo(other.cells[thisKeys[i]] is TigerShark);
                    }
                }
            }
            return 0;
        }

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
        {
            //8
            var isTigherShark = shark is TigerShark;
            if (c.cells.Count == c.maxCount)
            {
                throw new AquOverflowException();
            }
            int index = c.cells.Count;
            for (int i = 0; i < c.cells.Count; i++)
            {
                if (c.ChekFreeCell(i))
                {
                    index = i;
                }
                if (shark.GetType() == c.cells[i].GetType())
                {
                    if (isTigherShark)
                    {
                        if ((shark as TigerShark).Equals(c.cells[i]))
                        {
                            throw new AquariumAlreadyHaveException();
                        }
                    }
                    else if ((shark as Shark).Equals(c.cells[i]))
                    {
                        throw new AquariumAlreadyHaveException();
                    }
                }
            }
            if (index != c.cells.Count)
            {
                c.cells.Add(index, shark);
                return index;
            }
            c.cells.Add(c.cells.Count, shark);
            return c.cells.Count - 1;

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

            //7
            throw new AquIndexOutOfRangeException();
            //
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
