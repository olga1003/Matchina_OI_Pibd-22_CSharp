using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsLocomotive
{
    class TrainLocomotive
    {
        private float _startPosX;
        private float _startPosY;
        private int _pictureWidth;
        private int _pictureHeight;
        private const int carWidth = 100;
        private const int carHeight = 60;
        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }
        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }
        public bool Steam { private set; get; }

        public bool Coal { private set; get; }
        public TrainLocomotive(int maxSpeed, float weight, Color mainColor, Color dopColor,
        bool steam, bool coal)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Steam = steam;
            Coal = coal;

        }
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)

                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - carHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public void DrawTrain(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            if (Coal)
            {
                Brush coo = new SolidBrush(DopColor);
                g.FillEllipse(coo, _startPosX + 23, _startPosY + 35, 10, 7);
            }
            Brush spoiler = new SolidBrush(DopColor);
            g.FillRectangle(spoiler, _startPosX + 70, _startPosY + 25, 10, 15);
            g.FillRectangle(spoiler, _startPosX + 60, _startPosY + 30, 7, 10);
            g.FillRectangle(spoiler, _startPosX + 20, _startPosY + 55, 70, 7);
            Brush br = new SolidBrush(MainColor);
            g.FillRectangle(br, _startPosX + 20, _startPosY + 40, 70, 15);
            g.FillRectangle(br, _startPosX + 35, _startPosY + 20, 20, 20);
            Brush wh = new SolidBrush(Color.White);
            g.FillRectangle(wh, _startPosX + 36, _startPosY + 22, 18, 18);
            Brush gr = new SolidBrush(Color.Brown);
            g.FillEllipse(gr, _startPosX + 27, _startPosY + 50, 15, 15);
            g.FillEllipse(gr, _startPosX + 48, _startPosY + 50, 15, 15);
            g.FillEllipse(gr, _startPosX + 68, _startPosY + 50, 15, 15);
            if (Steam)
            {
                Brush st = new SolidBrush(Color.Gray);
                g.FillEllipse(st, _startPosX + 50, _startPosY + 10, 35, 15);

            }
        }
    }
}
