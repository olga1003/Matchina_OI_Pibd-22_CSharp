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
using NLog;

namespace WindowsFormsLocomotive
{
    public partial class FormDepot : Form
    {
        MultiLevelParking depot;
        FormTrainConfig form;
        private const int countLevel = 5;
        private Logger logger;
        public FormDepot()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
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
                    try
                    {


                        var locomotive = depot[listBoxLevels.SelectedIndex] -
                   Convert.ToInt32(maskedTextBox.Text);

                        Bitmap bmp = new Bitmap(pictureBoxTakeTrain.Width,
                       pictureBoxTakeTrain.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        locomotive.SetPosition(5, 5, pictureBoxTakeTrain.Width,
                       pictureBoxTakeTrain.Height);
                        locomotive.DrawTrain(gr);
                        pictureBoxTakeTrain.Image = bmp;
                        logger.Info("Изъят поезд " + locomotive.ToString() + " с места " + maskedTextBox.Text);
                        Draw();

                    }
                    catch (ParkingNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                        Bitmap bmp = new Bitmap(pictureBoxTakeTrain.Width,
                           pictureBoxTakeTrain.Height);
                        pictureBoxTakeTrain.Image = bmp;
                        logger.Error("На месте " + maskedTextBox.Text+" нет поезда");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Неизвестная ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                try
                {

                    int place = depot[listBoxLevels.SelectedIndex] + transport;
                    logger.Info("Добавлен поезд " + transport.ToString() + " на место " + place);
                    Draw();
                }
                catch (ParkingOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    logger.Error("Переполнение");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }           
            }
        }

        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    depot.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ЗагрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    depot.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
    MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);

                }
                catch (ParkingOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    logger.Error("Занятое место");
                }                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }
    }
}
