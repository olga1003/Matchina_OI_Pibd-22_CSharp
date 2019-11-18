using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WindowsFormsLocomotive
{
    class MultiLevelParking
    {
        List<Depot<ITransport>> parkingStages;
        private const int countPlaces = 20;
        private int pictureWidth;        private int pictureHeight;
        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Depot<ITransport>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Depot<ITransport>(countPlaces, pictureWidth,
               pictureHeight));
            }
        }
        public Depot<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter fs = new StreamWriter(filename, false, System.Text.Encoding.Default))
            {
                //Записываем количество уровней
                fs.WriteLine("CountLeveles:" + parkingStages.Count);
                foreach (var level in parkingStages)
                {
                    //Начинаем уровень
                    fs.WriteLine("Level");
                    for (int i = 0; i < countPlaces; i++)
                    {
                        var car = level[i];
                        if (car != null)
                        {
                            //если место не пустое
                            //Записываем тип мшаины
                            if (car.GetType().Name == "LocoTrain")
                            {
                                fs.Write(i + ":LocoTrain:");
                            }
                            if (car.GetType().Name == "TrainLocomotive")
                            {
                                fs.Write(i + ":TrainLocomotive:");
                            }
                            //Записываемые параметры
                            fs.WriteLine(car);
                        }
                    }
                }
            }
            return true;
        }
        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }

            using (StreamReader fs = new StreamReader(filename, System.Text.Encoding.Default))
            {
                int counter = -1;
                ITransport transport = null;
                string line;
                line = fs.ReadLine();
                if (line.Contains("CountLeveles"))
                {
                    //считываем количество уровней
                    int count = Convert.ToInt32(line.Split(':')[1]);
                    if (parkingStages != null)
                    {
                        parkingStages.Clear();
                    }
                    parkingStages = new List<Depot<ITransport>>(count);

                }
                else
                {
                    //если нет такой записи, то это не те данные
                    return false;
                }
                while (true)
                {
                    line = fs.ReadLine();
                    if (line == null)
                        break;

                    //идем по считанным записям
                    if (line == "Level")
                    {
                        counter++;
                        parkingStages.Add(new Depot<ITransport>(countPlaces,
pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    if (line.Split(':')[1] == "LocoTrain")
                    {
                        transport = new LocoTrain(line.Split(':')[2]);
                    }
                    else if (line.Split(':')[1] == "TrainLocomotive")
                    {
                        transport = new TrainLocomotive(line.Split(':')[2]);
                    }
                    parkingStages[counter][Convert.ToInt32(line.Split(':')[0])] = transport;
                }
                return true;
            }
        }

    }
}
