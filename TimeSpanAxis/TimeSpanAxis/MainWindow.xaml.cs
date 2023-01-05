using System;
using Syncfusion.UI.Xaml.Charts;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TimeSpanAxis_Sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class Model
    {
        public int Distance { get; set; }
        public TimeSpan Time { get; set; }
        
    }

    public class ViewModel
    {
        public List<Model> Data { get; set; }
      
        public ViewModel()
        {
            Data = new List<Model>()
            {
                new Model(){Distance = 100,Time = new TimeSpan(0,0,0,1,68),},
                new Model(){Distance = 300,Time = new TimeSpan( 0,0,0,2,105),},
                new Model(){Distance = 500,Time = new TimeSpan(0,0,0,3,200),},
                new Model(){Distance = 380,Time = new TimeSpan(0,0,0,4,254)},
                new Model(){Distance = 435,Time = new TimeSpan(0,0,0,5,68),},
                new Model(){Distance = 250,Time = new TimeSpan( 0,0,0,6,105),},
                new Model(){Distance = 470,Time = new TimeSpan(0,0,0,7,200),},
                new Model(){Distance = 620,Time = new TimeSpan(0,0,0,8,254)},
                new Model(){Distance = 470,Time = new TimeSpan(0,0,0,9,200),},
                new Model(){Distance = 580,Time = new TimeSpan(0,0,0,9,404)}
            };
        }
    }
}
