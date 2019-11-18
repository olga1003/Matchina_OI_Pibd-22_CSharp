using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLocomotive
{
    public partial class FormDepot : Form
    {
        MultiLevelParking depot;
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
        private void ButtonSetTrain_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var locomotive = new LocoTrain(100, 1000, dialog.Color);
                    int place = depot[listBoxLevels.SelectedIndex] + locomotive;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }
            }
        }
        private void ButtonSetLocoTrain_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var locomotive = new TrainLocomotive(100, 1000, dialog.Color,
                       dialogDop.Color, true, true, true);
                        int place = depot[listBoxLevels.SelectedIndex] + locomotive;
                        if (place == -1)
                        {
                            MessageBox.Show("Нет свободных мест", "Ошибка",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Draw();
                    }
                }
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
    }
}
