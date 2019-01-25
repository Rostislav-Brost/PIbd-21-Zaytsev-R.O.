using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
            //8
            int i = 0;
            foreach (var shark in aquariumStages[currentLevel])
            {
                shark.setPos(5 + i / 5 * cellW + 100, i % 5 * cellH + 40);
                shark.drawAnimal(g);
                i++;
            }

        }
        public void Sort()
        {
            aquariumStages.Sort();
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
        //6
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("CountLeveles:" + aquariumStages.Count + Environment.NewLine);
                    fs.Write(info, 0, info.Length);
                    foreach (var level in aquariumStages)
                    {
                        info = new UTF8Encoding(true).GetBytes("Level" + Environment.NewLine);
                        fs.Write(info, 0, info.Length);
                        for (int i = 0; i < countCell; i++)
                        {
                            var shark = level[i];
                            if (shark != null)
                            {
                                if (shark.GetType().Name == "Shark")
                                {
                                    info = new UTF8Encoding(true).GetBytes("Shark:");
                                    fs.Write(info, 0, info.Length);
                                }
                                if (shark.GetType().Name == "TigerShark")
                                {
                                    info = new UTF8Encoding(true).GetBytes("TigerShark:");
                                    fs.Write(info, 0, info.Length);
                                }
                                info = new UTF8Encoding(true).GetBytes(shark.getInfo() + Environment.NewLine);
                                fs.Write(info, 0, info.Length);
                            }
                        }
                    }
                }
            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                string s = "";
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] b = new byte[fs.Length];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (bs.Read(b, 0, b.Length) > 0)
                    {
                        s += temp.GetString(b);
                    }
                }
                s = s.Replace("\r", "");
                var strs = s.Split('\n');
                if (strs[0].Contains("CountLeveles"))
                {
                    int count = Convert.ToInt32(strs[0].Split(':')[1]);
                    if (aquariumStages != null)
                    {
                        aquariumStages.Clear();
                    }
                    aquariumStages = new List<ClassArray<IAnimals>>(count);
                }
                else
                {
                    return false;
                }
                int counter = -1;
                for (int i = 0; i < strs.Length; ++i)
                {
                    if (strs[i] == "Level")
                    {
                        counter++;
                        aquariumStages.Add(new ClassArray<IAnimals>(countCell, null));
                    }
                    else if (strs[i].Split(':')[0] == "Shark")
                    {
                        IAnimals shark = new Shark(strs[i].Split(':')[1]);
                        int number = aquariumStages[counter] + shark;
                        if (number == -1)
                        {
                            return false;
                        }
                    }
                    else if (strs[i].Split(':')[0] == "TigerShark")
                    {
                        IAnimals shark = new TigerShark(strs[i].Split(':')[1]);
                        int number = aquariumStages[counter] + shark;
                        if (number == -1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        //
    }
}

