using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RPM10
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
        private List<Zoo> listAmimals = new List<Zoo>();
        private Zoo selectedAnimals = null;

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Zoo Animals = null;
            switch (cbAnimals.Text)
            {
                case "Млекопитающие":
                    Animals = new Mammals();
                    break;
                case "Парнокопытные":
                    Animals = new Artiodactyls();
                    break;
                case "Птицы":
                    Animals = new Birds();
                    break;
            }
        }
    }
}