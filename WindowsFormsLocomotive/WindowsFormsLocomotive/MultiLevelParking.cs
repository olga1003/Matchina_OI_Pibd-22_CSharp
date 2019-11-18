using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLocomotive
{
    class MultiLevelParking
    {
        List<Depot<ITransport>> parkingStages;
        private const int countPlaces = 20;
        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Depot<ITransport>>();
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
    }
}
