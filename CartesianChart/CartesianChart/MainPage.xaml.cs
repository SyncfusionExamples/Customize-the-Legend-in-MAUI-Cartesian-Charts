using System.Collections.ObjectModel;

namespace CartesianChart
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }

    public class Model
    {
        public string Country { get; set; }
        public double OType { get; set; }
        public double AType { get; set; }
        public double BType { get; set; }
        public Model(string country, double otype, double atype, double btype)
        {
            Country = country;
            OType = otype;
            AType = atype;
            BType = btype;
        }
    }

    public class ViewModel
    {
        public ObservableCollection<Model> BloodType { get; set; }
        public ViewModel()
        {
            BloodType = new ObservableCollection<Model>()
            {
               new Model("US",37.40,35.70,8.50),
               new Model("Switzerland",26,37,13),
               new Model("Austria",30,33,12),
               new Model("Bulgaria",28,37,13),
               new Model("Poland",26.60,31.26,15.73),
               new Model("Myanmar",35.70,23.80,32.70),
            };
        }
    }
}
