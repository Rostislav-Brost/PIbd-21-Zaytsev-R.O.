//using NLog;
using NLog;
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

        //5
        FSelectColor form;
        //

        //7
        private Logger log;
        //

        public FAquarium()
        {
            InitializeComponent();

            //7
            log = LogManager.GetCurrentClassLogger();
            //

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
        {
            //4
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
        {
            //7
            log.Info("Попытка изъятия акулы с места " + Convert.ToInt32(FTicket.Text));
            //

            //4
            if (listBoxLevels.SelectedIndex > -1)
            {
                string level = listBoxLevels.Items[listBoxLevels.SelectedIndex].ToString();
                //
                if (FTicket.Text != "")
                {
                    //7
                    try
                    {
                        IAnimals shark = aquarium.GetSharkinAquarium(Convert.ToInt32(FTicket.Text));

                        Bitmap bmp = new Bitmap(FShark.Width, FShark.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        shark.setPos(30, 30);
                        shark.drawAnimal(gr);
                        FShark.Image = bmp;
                        log.Info("Изъятие акулы с места: успешно" + Convert.ToInt32(FTicket.Text));
                        Draw();
                    }
                    catch (AquIndexOutOfRangeException ex)
                    {
                        MessageBox.Show(ex.Message, "Неверный номер", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Общая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //
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

            //7
            log.Info("Переход на уровень ниже. Текущий уровень: " + aquarium.getCurrentLevel);
            //

            Draw();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            aquarium.LevelUp();
            listBoxLevels.SelectedIndex = aquarium.getCurrentLevel;

            //7
            log.Info("Переход на уровень выше. Текущий уровень: " + aquarium.getCurrentLevel);
            //

            Draw();
        }
        //

        //5
        private void button1_Click(object sender, EventArgs e)
        {
            //7
            log.Info("Добавление акулы на уровень " + aquarium.getCurrentLevel);
            //

            form = new FSelectColor();
            form.AddEvent(AddShark);
            form.Show();
        }
        private void AddShark(IAnimals shark)
        {
            //7
            if (shark != null)
            {
                try
                {
                    int place = aquarium.PutSharkInAquarium(shark);
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
                catch (AquOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка переполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Общая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //
        }

        //6
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //7
                log.Info("Попытка загрузки");
                //

                if (aquarium.SaveData(saveFileDialog1.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //7
                    log.Info("Сохранение: успешно");
                    //
                }
                else
                {
                    MessageBox.Show("НЕ сохранилось", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //
                    log.Info("Сохранение: НЕ успешно");
                    //
                }
            }
        }
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //7
            log.Info("Попытка загрузки");
            //
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (aquarium.LoadData(openFileDialog1.FileName))
                {
                    MessageBox.Show("Загрузили", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //7
                    log.Info("Загрузка: успешно");
                    //
                }
                else
                {
                    MessageBox.Show("Не загрузили", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //7
                    log.Info("Загрузка: НЕ успешно");
                    //
                }
                Draw();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aquarium.Sort();
            Draw();
        }
        //
    }
}

