using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsLocomotive
{
    class TrainLocomotive : LocoTrain
    {
        public Color DopColor { private set; get; }
        public bool Steam { private set; get; }
        public bool Coal { private set; get; }
        public bool Pipe { private set; get; }
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
        public TrainLocomotive(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Coal = Convert.ToBoolean(strs[4]);
                Pipe = Convert.ToBoolean(strs[5]);
            }
        }

        public override void DrawTrain(Graphics g)
        {
            Brush dopBrush = new SolidBrush(DopColor);
            if (Coal)
            {
                Brush coo = new SolidBrush(DopColor);
                g.FillEllipse(coo, _startPosX + 23, _startPosY + 35, 10, 7);
            }
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
            base.DrawTrain(g);
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Coal + ";" +
           Steam;
        }
    }
}