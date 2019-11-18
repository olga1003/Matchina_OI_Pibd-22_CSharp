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
    public partial class FormTrainConfig : Form
    {
        ITransport transport = null;
        private event trainDelegate eventAddTrain;
        public FormTrainConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        private void DrawTrain()
        {
            if (transport != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxTrain.Width, pictureBoxTrain.Height);
                Graphics gr = Graphics.FromImage(bmp);
                transport.SetPosition(5, 5, pictureBoxTrain.Width, pictureBoxTrain.Height);
                transport.DrawTrain(gr);
                pictureBoxTrain.Image = bmp;
            }
        }
        public void AddEvent(trainDelegate ev)
        {
            if (eventAddTrain == null)
            {
                eventAddTrain = new trainDelegate(ev);
            }
            else
            {
                eventAddTrain += ev;
            }
        }
        private void labelTrain_MouseDown(object sender, MouseEventArgs e)
        {
            labelTrain.DoDragDrop(labelTrain.Text, DragDropEffects.Move |
DragDropEffects.Copy);
        }
        private void labelLocomotive_MouseDown(object sender, MouseEventArgs e)
        {
            labelLocomotive.DoDragDrop(labelLocomotive.Text, DragDropEffects.Move |
            DragDropEffects.Copy);
        }
        private void panelTrain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void PanelTrain_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Локомотив":
                    transport = new LocoTrain(100, 500, Color.White);
                    break;
                case "Тепловоз":
                    transport = new TrainLocomotive(100, 500, Color.White, Color.Black, true, true,
                   true);
                    break;
            }
            DrawTrain();
        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
DragDropEffects.Move | DragDropEffects.Copy);
        }    
        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            if (transport != null)
            {
                transport.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawTrain();
            }
        }
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (transport != null)
            {
                if (transport is TrainLocomotive)
                {
                    (transport as
                   TrainLocomotive).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawTrain();
                }
            }
        }
        private void ButtonAdd_Click_1(object sender, EventArgs e)
        {
            eventAddTrain?.Invoke(transport);
            Close();
        }
    }
}
