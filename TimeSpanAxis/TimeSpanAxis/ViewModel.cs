using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpanAxis
{
    public class ViewModel
    {
        public ObservableCollection<DataPoint> Data { get; set; }

        public ViewModel()
        {
            Data = new ObservableCollection<DataPoint>
            {
                new DataPoint { Time = new TimeSpan(0, 0, 0, 0, 0), Distance = 50 },
                new DataPoint { Time = new TimeSpan(0, 0, 0, 2), Distance = 100 },
                new DataPoint { Time = new TimeSpan(0, 0, 0, 4), Distance = 200 },
                new DataPoint { Time = new TimeSpan(0, 0, 0, 6), Distance = 350 },
                new DataPoint { Time = new TimeSpan(0, 0, 0, 8), Distance = 500 },
                new DataPoint { Time = new TimeSpan(0, 0, 0, 10), Distance = 650 }
            };
        }
    }
}
