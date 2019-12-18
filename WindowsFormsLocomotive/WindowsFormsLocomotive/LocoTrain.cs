using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLocomotive
{
    class LocoTrain : Train, IComparable<LocoTrain>, IEquatable<LocoTrain>
    {
        protected const int locoWidth = 100;
        protected const int locoHeight = 60;
        public LocoTrain(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        public LocoTrain(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - locoWidth)
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
                    if (_startPosY + step < _pictureHeight - locoHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawTrain(Graphics g)
        {
            Brush spoiler = new SolidBrush(Color.Black);
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
        }
                public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }
        public int CompareTo(LocoTrain other)
        {
            if (other == null)
            {
                return 1;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if (MainColor != other.MainColor)
            {
                MainColor.Name.CompareTo(other.MainColor.Name);
            }
            return 0;
        }        public bool Equals(LocoTrain other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is LocoTrain carObj))
            {
                return false;
            }
            else
            {
                return Equals(carObj);
            }
        }        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
