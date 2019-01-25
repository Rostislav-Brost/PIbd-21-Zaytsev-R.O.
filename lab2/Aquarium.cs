using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Aquarium
    {
        ClassArray<IAnimals> aquarium;
        int countCell = 10;
        int cellW = 310;
        int cellH = 80;

        public Aquarium()
        {
            aquarium = new ClassArray<IAnimals>(countCell, null);
        }

        public int PutSharkInAquarium(IAnimals shark)
        {
            return aquarium + shark;
        }

        public IAnimals GetSharkinAquarium(int ticket)
        {
            return aquarium - ticket;
        }

        public void Draw(Graphics g, int w, int h)
        {
            DrawCells(g);
            for (int i = 0; i < countCell; i++)
            {
                var shark = aquarium.getObject(i);
                if (shark != null)
                {
                    shark.setPos(5 + i / 5 * cellW + 100, i % 5 * cellH + 40);
                    shark.drawAnimal(g);
                }
            }
        }

        private void DrawCells(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);

            for (int i = 0; i < countCell / 5; i++)
            {
                for (int j = 0; j < 6; ++j)
                {
                    g.DrawLine(pen, i * cellW, j * cellH, i * cellW + 310, j * cellH);
                    g.DrawLine(pen, i * cellW, j * cellH, i * cellW, j * cellH + 210);
                }
            }
        }
    }
}

