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
    public partial class FormLocomotive : Form
    {
        private ITransport locomotive;
        public FormLocomotive()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxLocomotive.Width, pictureBoxLocomotive.Height);
            Graphics gr = Graphics.FromImage(bmp);
            locomotive.DrawCar(gr);
            pictureBoxLocomotive.Image = bmp;
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            locomotive = new LocoTrain(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue);
            locomotive.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxLocomotive.Width,
           pictureBoxLocomotive.Height);
            Draw();
        }
        private void ButtonCreateLocoTrain_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            locomotive = new TrainLocomotive(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue,
           Color.Black, true, true,true);
            locomotive.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxLocomotive.Width,
           pictureBoxLocomotive.Height);
            Draw();
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    locomotive.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    locomotive.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    locomotive.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    locomotive.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

       
    }
}
