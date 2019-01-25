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
    public partial class FAquarium : Form
    {
        Aquarium aquarium;
        public FAquarium()
        {
            InitializeComponent();
            aquarium = new Aquarium();
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(FAqu.Width, FAqu.Height);
            Graphics gr = Graphics.FromImage(bmp);
            aquarium.Draw(gr, FAqu.Width, FAqu.Height);
            FAqu.Image = bmp;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FSetShark_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var shark = new Shark(15, 15, 15, dialog.Color);
                int place = aquarium.PutSharkInAquarium(shark);
                Draw();
                MessageBox.Show("Ваше место: " + place);
            }
        }

        private void FSetTShark_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var shark = new TigerShark(10, 10, 10, dialog.Color, true, dialogDop.Color);
                    int place = aquarium.PutSharkInAquarium(shark);
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
            }
        }

        private void FGet_Click(object sender, EventArgs e)
        {
            if (FTicket.Text != "")
            {
                IAnimals shark = aquarium.GetSharkinAquarium(Convert.ToInt32(FTicket.Text));
                if (shark != null)
                {
                    Bitmap bmp = new Bitmap(FShark.Width, FShark.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    shark.setPos(30, 30);
                    shark.drawAnimal(gr);
                    FShark.Image = bmp;
                    Draw();
                }
            }
        }
    }
}
