using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLocomotive
{
    public partial class FormDepot : Form
    {
        MultiLevelParking depot;

        FormTrainConfig form;

        private const int countLevel = 5;
        public FormDepot()
        {
            InitializeComponent();
            depot = new MultiLevelParking(countLevel, pictureBoxDepot.Width,
           pictureBoxDepot.Height);
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {

                Bitmap bmp = new Bitmap(pictureBoxDepot.Width,
               pictureBoxDepot.Height);
                Graphics gr = Graphics.FromImage(bmp);
                depot[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxDepot.Image = bmp;
            }
        }
        private void ButtonTakeTrain_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox.Text != "")
                {
                    var locomotive = depot[listBoxLevels.SelectedIndex] -
                   Convert.ToInt32(maskedTextBox.Text);
                    if (locomotive != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTakeTrain.Width,
                       pictureBoxTakeTrain.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        locomotive.SetPosition(5, 5, pictureBoxTakeTrain.Width,
                       pictureBoxTakeTrain.Height);
                        locomotive.DrawTrain(gr);
                        pictureBoxTakeTrain.Image = bmp;
                    }
                    else
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTakeTrain.Width,
                       pictureBoxTakeTrain.Height);
                        pictureBoxTakeTrain.Image = bmp;
                    }
                    Draw();
                }
            }
        }
        private void ListBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void ButtonSetTrain_Click_1(object sender, EventArgs e)
        {
            form = new FormTrainConfig();
            form.AddEvent(AddTrain);
            form.Show();
        }

        private void AddTrain(ITransport transport)
        {
            if (transport != null && listBoxLevels.SelectedIndex > -1)
            {
                int place = depot[listBoxLevels.SelectedIndex] + transport;
                if (place > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Поезд не удалось поставить");
                }
            }
        }

        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (depot.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ЗагрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (depot.LoadData(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
     MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                Draw();
            }
        }
    }
}
