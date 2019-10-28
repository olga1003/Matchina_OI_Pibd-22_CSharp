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
        Depot<ITransport> depot;
        public FormDepot()
        {
            InitializeComponent();
            depot = new Depot<ITransport>(20, pictureBoxDepot.Width,
pictureBoxDepot.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxDepot.Width, pictureBoxDepot.Height);
            Graphics gr = Graphics.FromImage(bmp);
            depot.Draw(gr);
            pictureBoxDepot.Image = bmp;
        }


        private void ButtonSetTrain_Click(object sender, EventArgs e)
        {

            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var car = new LocoTrain(100, 1000, dialog.Color);
                int place = depot + car;
                Draw();
            }
        }
        private void ButtonSetLocoTrain_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var car = new TrainLocomotive(100, 1000, dialog.Color, dialogDop.Color,
                   true, true, true);
                    int place = depot + car;
                    Draw();
                }
            }
        }
        private void ButtonTakeTrain_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var car = depot - Convert.ToInt32(maskedTextBox.Text);
                if (car != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeTrain.Width,
                   pictureBoxTakeTrain.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    car.SetPosition(5, 5, pictureBoxTakeTrain.Width,
                   pictureBoxTakeTrain.Height);
                    car.DrawTrain(gr);
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
}
