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
        //5
        FSelectColor form;
        //

        Aquarium aquarium;
        public FAquarium()
        {
            InitializeComponent();
            aquarium = new Aquarium(5);

            //4
            for (int i = 1; i < 6; i++)
            {
                listBoxLevels.Items.Add("Level " + i);
            }
            listBoxLevels.SelectedIndex = aquarium.getCurrentLevel;
            //
            Draw();
        }

        private void Draw()
        { //4
            if (listBoxLevels.SelectedIndex > -1)
            //
            {
                Bitmap bmp = new Bitmap(FAqu.Width, FAqu.Height);
                Graphics gr = Graphics.FromImage(bmp);
                aquarium.Draw(gr, FAqu.Width, FAqu.Height);
                FAqu.Image = bmp;
            }
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
        { //4
            if (listBoxLevels.SelectedIndex > -1)
            {
                string level = listBoxLevels.Items[listBoxLevels.SelectedIndex].ToString();
                //
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //4
        private void buttonDown_Click(object sender, EventArgs e)
        {
            aquarium.LevelDown();
            listBoxLevels.SelectedIndex = aquarium.getCurrentLevel;
            Draw();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            aquarium.LevelUp();
            listBoxLevels.SelectedIndex = aquarium.getCurrentLevel;
            Draw();
        }
        //
        //5
        private void button1_Click(object sender, EventArgs e)
        {
            form = new FSelectColor();
            //   form.AddEvent(AddShark);
            form.Show();
        }
        private void AddShark(IAnimals shark)
        {
            if (shark != null)
            {
                int place = aquarium.PutSharkInAquarium(shark);
                if (place > -1)
                {
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
                else
                {
                    MessageBox.Show("акулу не удалось посадить в клетку");
                }
            }
        }
        //
    }
}

