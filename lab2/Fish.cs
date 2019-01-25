using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public abstract class Fish : IAnimals
    {
        protected float startPosX;
        protected float startPosY;

        public abstract void drawAnimal(Graphics g);
        public abstract void moveAnimal(Graphics g);

        public void setPos(int x, int y)
        {
            startPosX = x;
            startPosY = y;
        }

        protected int age;
        public virtual int Age { protected set; get; }
        public void grow(int a)
        {
            if (age + a < Age)
            {
                age++;
            }
        }

        public virtual double Speed { protected set; get; }
        public virtual int Weight { protected set; get; }
        public Color ColorBody { protected set; get; }

        //5
        public virtual void setMainColor(Color color)
        {
            ColorBody = color;
        }
        //

        //6
        public abstract string getInfo();
        //
    }
}
