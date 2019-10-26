using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

public enum Direction
{
    Up,
    Down,
    Left,
    Right
}

namespace WindowsFormsLocomotive
{
    /// Класс отрисовки автомобиля
    class TrainLocomotive : LocoTrain
    {
        public Color DopColor { private set; get; }

        /// <summary>
        /// Признак наличия переднего спойлера
        /// </summary>
        public bool Steam { private set; get; }
        /// <summary>
        /// Признак наличия боковых спойлеров
        /// </summary>
        public bool Coal { private set; get; }

        public bool Pipe { private set; get; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="frontSpoiler">Признак наличия переднего спойлера</param>
        /// <param name="sideSpoiler">Признак наличия боковых спойлеров</param>
        /// <param name="backSpoiler">Признак наличия заднего спойлера</param>
        public TrainLocomotive(int maxSpeed, float weight, Color mainColor, Color dopColor,
bool steam, bool coal, bool pipe) :
 base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            Steam = steam;
            Coal = coal;
            Pipe = pipe;
            Random rnd = new Random();
        }

        /// <summary>
        /// Отрисовка автомобиля
        /// </summary>
        /// <param name="g"></param>
        public override void DrawCar(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopBrush = new SolidBrush(DopColor);
            // отрисуем сперва передний спойлер автомобиля (чтобы потом отрисовка  автомобиля на него "легла")
             if (Coal)
             {

                Brush coo = new SolidBrush(DopColor);
                g.FillEllipse(coo, _startPosX + 23, _startPosY + 35, 10, 7);

            }
            // и боковые
            if (Steam)
            {
                Brush st = new SolidBrush(Color.Gray);
                g.FillEllipse(st, _startPosX + 50, _startPosY + 10, 35, 15);

            }
            if (Pipe)
            {
                Brush st = new SolidBrush(DopColor);
                g.FillRectangle(st, _startPosX + 70, _startPosY + 25, 10, 15);

            }
            base.DrawCar(g);         
        }
    }
}