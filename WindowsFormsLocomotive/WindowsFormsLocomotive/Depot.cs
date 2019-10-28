using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsLocomotive
{
    public class Depot<T> where T : class, ITransport
    {
        private T[] _places;
        private int PictureWidth { get; set; }
        private int PictureHeight { get; set; }
        private const int _placeSizeWidth = 120;
        private const int _placeSizeHeight = 80;
        public Depot(int sizes, int pictureWidth, int pictureHeight)
        {
            _places = new T[sizes];
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i] = null;
            }
        }
        public static int operator +(Depot<T> p, T transport)
        {
            for (int i = 0; i < p._places.Length; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p._places[i] = transport;
                    p._places[i].SetPosition(5 + i / 5 * _placeSizeWidth + 5,
                     i % 5 * _placeSizeHeight + 15, p.PictureWidth,
                    p.PictureHeight);
                    return i;
                }
            }
            return -1;
        }
        public static T operator -(Depot<T> p, int index)
        {
            if (index < 0 || index > p._places.Length)
            {
                return null;
            }
            if (!p.CheckFreePlace(index))
            {
                T car = p._places[index];
                p._places[index] = null;
                return car;
            }
            return null;
        }
        private bool CheckFreePlace(int index)
        {
            return _places[index] == null;
        }
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                if (!CheckFreePlace(i))
                {//если место не пустое
                    _places[i].DrawTrain(g);
                }
            }
        }
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, 0, 0, (_places.Length / 5) * _placeSizeWidth, 320);
            for (int i = 0; i < _places.Length / 5; i++)
            {
                for (int j = 0; j < 6; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight + 70,
                   i * _placeSizeWidth + 1000, j * _placeSizeHeight + 70);

                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight + 80,
                   i * _placeSizeWidth + 1000, j * _placeSizeHeight + 80);
                    g.DrawLine(pen, i * _placeSizeWidth + 60, j * _placeSizeHeight + 70, i * _placeSizeWidth + 70, j * _placeSizeHeight + 80);
                }
            }
        }
    }
}