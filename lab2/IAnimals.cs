using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public interface IAnimals
    {
        void moveAnimal(Graphics g);
        void drawAnimal(Graphics g);
        void setPos(int x, int y);
        void grow(int a);
        // 5
        void setMainColor(Color color);
        //
    }
}
