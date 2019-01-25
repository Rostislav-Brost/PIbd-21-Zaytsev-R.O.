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
        //4
        List<ClassArray<IAnimals>> aquariumStages;
        int currentLevel;
        //
        int countCell = 10;
        int cellW = 310;
        int cellH = 80;
        //4
        public int getCurrentLevel
        {
            get
            {
                return currentLevel;
            }
        }
        //

        //4
        public Aquarium(int countStages)
        {
            aquariumStages = new List<ClassArray<IAnimals>>(countStages);
            for (int i = 0; i < countStages; i++)
            {
                aquarium = new ClassArray<IAnimals>(countCell, null);
                aquariumStages.Add(aquarium);
            }
        }

        public void LevelUp()
        {
            if (currentLevel + 1 < aquariumStages.Count)
            {
                currentLevel++;
            }
        }

        public void LevelDown()
        {
            if (currentLevel > 0)
            {
                currentLevel--;
            }
        }
        //
        public int PutSharkInAquarium(IAnimals shark)
        {

            //4
            return aquariumStages[currentLevel] + shark;
            //
        }

        public IAnimals GetSharkinAquarium(int ticket)
        {
            //4
            return aquariumStages[currentLevel] - ticket;
            //
        }

        public void Draw(Graphics g, int w, int h)
        {
            DrawCells(g);
            for (int i = 0; i < countCell; i++)
            {
                //4
                var shark = aquariumStages[currentLevel][i];
                //

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
            //4
            g.DrawString(("L" + currentLevel + 1), new Font("Arial", 30), new SolidBrush(Color.Blue), (countCell / 5) * cellW - 70, 420);
            //
            for (int i = 0; i < countCell / 5; i++)
            {
                for (int j = 0; j < 6; ++j)
                {
                    g.DrawLine(pen, i * cellW, j * cellH, i * cellW + 310, j * cellH);
                    g.DrawLine(pen, i * cellW, j * cellH, i * cellW, j * cellH + 210);
                    //4
                    if (j < 5)
                    {
                        g.DrawString((i * 5 + j).ToString(), new Font("Arial", 30), new SolidBrush(Color.Blue), i * cellW + 30, j * cellH + 20);
                    }
                    //
                }
            }
        }
    }
}

