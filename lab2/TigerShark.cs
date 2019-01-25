using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class TigerShark : Shark, IComparable<TigerShark>, IEquatable<Shark>
    {
        //8
        public int CompareTo(TigerShark other)
        {
            var res = (this is Shark).CompareTo(other is Shark);
            if (res != 0)
            {
                return res;
            }
            if (bands != other.bands)
            {
                return bands.CompareTo(other.bands);
            }
            if (ColorBody != other.ColorBody)
            {
                ColorBody.Name.CompareTo(other.ColorBody
                    .Name);
            }
            if (dopColor != other.dopColor)
            {
                dopColor.Name.CompareTo(other.dopColor
                    .Name);
            }
            return 0;
        }

        public bool Equals(TigerShark other)
        {
            var res = (this is Shark).Equals(other is Shark);
            if (!res)
            {
                return res;
            }
            if (bands != other.bands)
            {
                return false;
            }
            if (dopColor != other.dopColor)
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
            TigerShark sharkObj = obj as TigerShark;
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

        private bool bands;
        private Color dopColor;

        public TigerShark(double speed, int Age, int weight, Color color, bool bands, Color dopColor) : base(speed, Age, weight, color)
        {
            this.bands = bands;
            this.dopColor = dopColor;
        }

        //6
        public TigerShark(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 6)
            {
                Speed = Convert.ToInt32(strs[0]);
                Age = Convert.ToInt32(strs[1]);
                Weight = Convert.ToInt32(strs[2]);
                ColorBody = Color.FromName(strs[3]);
                bands = Convert.ToBoolean(strs[4]);
                dopColor = Color.FromName(strs[5]);
            }
            Random rand = new Random();
            startPosX = rand.Next(10, 200);
            startPosY = rand.Next(10, 200);
        }
        //

        protected override void draw1Shark(Graphics g)
        {
            base.draw1Shark(g);
            if (bands)
            {
                //Drawing2
                Pen pen = new Pen(dopColor, 6);

                g.DrawLine(pen, startPosX + Age * 3, startPosY - Weight, startPosX + Age * 4, startPosY);
                g.DrawLine(pen, startPosX + Age * 6, startPosY - Weight / 2, startPosX + Age * 7, startPosY);
            }
        }
        //5
        public void setDopColor(Color color)
        {
            dopColor = color;
        }
        //

        //6
        public override string getInfo()
        {
            return Speed + ";" + Age + ";" + Weight + ";" + ColorBody.Name + ";" + bands + ";" + dopColor.Name;
        }
        //
    }
}