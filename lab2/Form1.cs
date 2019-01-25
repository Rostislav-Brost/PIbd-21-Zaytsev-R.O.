using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2 { 
 public partial class Form1 : Form
{
    Color color;
    Color dopcolor;
    double speed;
    int weight;
    int age;
    bool bands = false;

    private IAnimals inter;

    public Form1()
    {
        InitializeComponent();
        color = Color.White;
        dopcolor = Color.Yellow;
        speed = 35;
        age = 18;
        weight = 500;
        FColor1.BackColor = color;
        FColor2.BackColor = dopcolor;
    }

    private void FSpeed_TextChanged(object sender, EventArgs e)
    {

    }

    private void FWeight_TextChanged(object sender, EventArgs e)
    {

    }

    private void FColor1_Click(object sender, EventArgs e)
    {
        ColorDialog cd = new ColorDialog();
        if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        {
            color = cd.Color;
            FColor1.BackColor = color;
        }

    }

    private void FAge_TextChanged(object sender, EventArgs e)
    {

    }

    private void FShark_Click(object sender, EventArgs e)
    {
        if (checkFields())
        {
            inter = new Shark(speed, age, weight, color);
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            inter.drawAnimal(gr);
            pictureBox1.Image = bmp;
        }

    }

    private void FBands_CheckedChanged(object sender, EventArgs e)
    {
        if (FBands.Checked)
        {
            bands = true;
        }
    }

    private void FColor2_Click(object sender, EventArgs e)
    {
        ColorDialog cd = new ColorDialog();

        if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        {
            dopcolor = cd.Color;
            FColor2.BackColor = dopcolor;
        }
    }

    private void FTigerSark_Click(object sender, EventArgs e)
    {
        inter = new TigerShark(speed, age, weight, color, bands, dopcolor);
        Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        Graphics gr = Graphics.FromImage(bmp);
        inter.drawAnimal(gr);
        pictureBox1.Image = bmp;
    }

    private bool checkFields()
    {
        if (!double.TryParse(FSpeed.Text, out speed))
        {
            return false;
        }
        if (!int.TryParse(FAge.Text, out age))
        {
            return false;
        }
        if (!int.TryParse(FWeight.Text, out weight))
        {
            return false;
        }
        return true;
    }

    private void button3_Click(object sender, EventArgs e)
    {
        if (inter != null)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            inter.moveAnimal(gr);
            pictureBox1.Image = bmp;
        }

    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
