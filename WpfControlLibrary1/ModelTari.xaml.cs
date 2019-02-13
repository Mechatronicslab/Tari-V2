
using MongoDB.Driver;
using System;
using System.Collections.Generic;
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

namespace WpfControlLibrary1
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        string MongoCString = "mongodb://maria:maria123@167.205.7.226:27017/kinect";
        IMongoDatabase db;
        IMongoCollection<BrekelMongo> collection;
        DataHolder dH = new DataHolder();
        string selectedDB;
        bool _play = false;
        public UserControl1()
        {
            InitializeComponent();
            MongoClient client = new MongoClient(MongoCString);
            db = client.GetDatabase("kinect");
            var listclct = db.ListCollections().ToList();
            List<string> clctnames = new List<string>();
            foreach (var doc in listclct)
            {
                clctnames.Add(doc["name"].ToString());
            }
            CBx.ItemsSource = clctnames;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            canvas.Children.Clear();
            SideCanvas.Children.Clear();
            int valueS = (int)Math.Round(Suraido.Value, 0);
            SlideLab.Content = Suraido.Value.ToString();
            try
            {
                dH.LoadRow(collection, valueS);
                canvas.DrawSkeleton(dH.skeleton[0]);
                SideCanvas.DrawSkeletonSide(dH.skeleton[0]);
            }
            catch
            {
                MessageBox.Show("Please load data first");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_play)
            {
                _play = !_play;
                PlayB.Content = "PLAY";
            }
            else
            {
                _play = !_play;
                PlayB.Content = "STOP";
            }
        }

        private void CBx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedDB = CBx.SelectedItem.ToString();
        }

        private void LOAD_Click(object sender, RoutedEventArgs e)
        {
            var filter = FilterDefinition<BrekelMongo>.Empty;
            collection = db.GetCollection<BrekelMongo>(selectedDB);
            Suraido.Maximum = collection.Find(filter).Count() - 1;
            dH.LoadRow(collection, 0);
            canvas.Children.Clear();
            SideCanvas.Children.Clear();
            canvas.DrawSkeleton(dH.skeleton[0]);
            SideCanvas.DrawSkeletonSide(dH.skeleton[0]);
        }
    }
}
