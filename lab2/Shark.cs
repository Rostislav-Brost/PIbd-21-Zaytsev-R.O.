﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Shark : Fish, IComparable<Shark>, IEquatable<Shark>
    {
        //8
        public int CompareTo(Shark other)
        {
            if (other == null)
            {
                return 1;
            }
            if (Age != other.Age)
            {
                return Age.CompareTo(other.Age);
            }
            if (Speed != other.Speed)
            {
                return Speed.CompareTo(other.Speed);
            }
            if (Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if (ColorBody != other.ColorBody)
            {
                ColorBody.Name.CompareTo(other.ColorBody.Name);
            }
            return 0;
        }

        public bool Equals(Shark other)
        {
            if (other == null)
            {
                return false;
            }
            if (Speed != other.Speed)
            {
                return false;
            }
            if (Age != other.Age)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (ColorBody != other.ColorBody)
            {
                return false;
            }
            return true;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Shark sharkObj = obj as Shark;
            if (sharkObj == null)
            {
                return false;
            }
            else
            {
                return Equals(sharkObj);
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override int Age
        {
            get
            {
                return base.Age;
            }

            protected set
            {
                if (value > 0 && value < 30)
                {
                    base.Age = value;
                }
                else
                {
                    base.Age = 20;
                }
            }
        }
        public override double Speed
        {
            get
            {
                return base.Speed;
            }

            protected set
            {
                if (value > 0 && value < 50)
                {
                    base.Speed = value;
                }
                else
                {
                    base.Speed = 30;
                }
            }
        }
        public override int Weight

        {
            get
            {
                return base.Weight;
            }

            protected set
            {
                if (value > 0 && value < 30)
                {
                    base.Weight = value;
                }
                else
                {
                    base.Weight = 25;
                }
            }
        }

        public Shark(double speed, int age, int weight, Color color)
        {
            this.Speed = speed;
            this.Age = age;
            this.ColorBody = color;
            this.Weight = weight;
            Random rand = new Random();
            startPosX = rand.Next(10, 200);
            startPosY = rand.Next(10, 200);
        }

        //6
        public Shark(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 4)
            {
                Speed = Convert.ToInt32(strs[0]);
                Age = Convert.ToInt32(strs[1]);
                Weight = Convert.ToInt32(strs[2]);
                ColorBody = Color.FromName(strs[3]);
            }
            Random rand = new Random();
            startPosX = rand.Next(10, 200);
            startPosY = rand.Next(10, 200);
        }
        //

        public override void moveAnimal(Graphics g)
        {
            startPosX -= ((float)Speed);
            drawAnimal(g);
        }

        public override void drawAnimal(Graphics g)
        {
            draw1Shark(g);
        }

        protected virtual void draw1Shark(Graphics g)
        {
            //Drawing1
            Pen pen = new Pen(ColorBody, 6);

            //Body
            g.DrawLine(pen, startPosX, startPosY, startPosX + Age * 3, startPosY - Weight);
            g.DrawLine(pen, startPosX + Age * 3, startPosY - Weight, startPosX + Age * 9, startPosY);
            g.DrawLine(pen, startPosX, startPosY, startPosX + Age * 3, startPosY + Weight);
            g.DrawLine(pen, startPosX + Age * 3, startPosY + Weight, startPosX + Age * 9, startPosY);

            //Fin
            g.DrawLine(pen, startPosX + Age * 3, startPosY - Weight, startPosX + Age * 6, startPosY - Weight * 2);
            g.DrawLine(pen, startPosX + Age * 6, startPosY - Weight * 2, startPosX + Age * 6, startPosY - Weight / 2);

            //Tail
            g.DrawLine(pen, startPosX + Age * 9, startPosY, startPosX + Age * 11, startPosY + Weight);
            g.DrawLine(pen, startPosX + Age * 9, startPosY, startPosX + Age * 11, startPosY - Weight);
            g.DrawLine(pen, startPosX + Age * 11, startPosY + Weight, startPosX + Age * 10, startPosY);
            g.DrawLine(pen, startPosX + Age * 11, startPosY - Weight, startPosX + Age * 10, startPosY);
        }

        //6
        public override string getInfo()
        {
            return Speed + ";" + Age + ";" + Weight + ";" + ColorBody.Name;
        }
        //
    }
}
