using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class FSelectColor : Form
    {
        IAnimals shark = null;

        public IAnimals getShark { get { return shark; } }

        private void drawAnimal()
        {
            if (shark != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxCar.Width, pictureBoxCar.Height);
                Graphics gr = Graphics.FromImage(bmp);
                shark.setPos(20, 50);
                shark.drawAnimal(gr);
                pictureBoxCar.Image = bmp;
            }
        }

        private event myDel eventAddShark;

        /*    public void AddEvent(myDel ev)
            {
                if (eventAddShark == null)
                {
                    eventAddShark = new myDel(ev);
                }
                else
                {
                    eventAddShark += ev;
                }
            }*/
        public FSelectColor()
        {
            InitializeComponent();
            FCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void FCShark_MouseDown(object sender, MouseEventArgs e)
        {
            FCShark.DoDragDrop(FCShark.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void FCTigherShark_MouseDown(object sender, MouseEventArgs e)
        {
            FCTigherShark.DoDragDrop(FCTigherShark.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void FCOk_Click(object sender, EventArgs e)
        {
            if (eventAddShark != null)
            {
                eventAddShark(shark);

            }
            Close();
        }

        private void panelCar_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Shark":
                    shark = new Shark(100, 8, 500, Color.White);
                    break;
                case "TigherShark":
                    shark = new TigerShark(100, 8, 500, Color.White, true, Color.Black);
                    break;
            }
            drawAnimal();
        }

        private void panelCar_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void FDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (shark != null)
            {
                if (shark is TigerShark)
                {
                    (shark as TigerShark).setDopColor((Color)e.Data.GetData(typeof(Color)));
                    drawAnimal();
                }
            }
        }

        private void FBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void FBaseColor_DradDrop(object sender, DragEventArgs e)
        {
            if (shark != null)
            {
                shark.setMainColor((Color)e.Data.GetData(typeof(Color)));
                drawAnimal();
            }
        }
    }
}
