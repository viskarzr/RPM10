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
            cbAnimals.Items.Add("Млекопитающие");
            cbAnimals.Items.Add("Парнокопытные");
            cbAnimals.Items.Add("Птицы");
        }
        private List<Zoo> listAmimals = new List<Zoo>();
        private Zoo selectedAnimals = null;

        private void UpdateAnimalsList()
        {
            lbAnimal.ItemsSource = null;
            lbAnimal.ItemsSource = listAmimals;
        }

        private void ClearFields()
        {
            tbId.Clear();
            tbName.Clear();
            tbAge.Clear();
            tbWeight.Clear();
            cbAnimals.SelectedIndex = 0;
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            bool f1, f2, f3;
            f1 = int.TryParse(tbAge.Text, out int age);
            f2 = double.TryParse(tbWeight.Text, out double weight);
            f3 = int.TryParse(tbId.Text, out int id);
            if (f1 == f2 == f3 == true && age > 0 && age < 100 && weight > 0)
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
                if (Animals != null)
                {
                    Animals.UpdateAnimals(id,tbName.Text, age, weight);
                    UpdateAnimalsList();
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Проверьте корректность ввода!\n Пометка:\nВозраст должен быть в диапозоне от 0 до 100, a вес больше 0");
            }
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            bool f1, f2, f3;
            f1 = int.TryParse(tbAge.Text, out int age);
            f2 = double.TryParse(tbWeight.Text, out double weight);
            f3 = int.TryParse(tbId.Text, out int id);
            if (f1 == f2 == f3 == true && age > 0 && age < 100 && weight > 0)
            {
                if (selectedAnimals != null)
                {
                    try
                    {
                        selectedAnimals.UpdateAnimals(id, tbName.Text, age, weight);
                        UpdateAnimalsList();
                        ClearFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Проверьте корректность ввода или выберите животное для изменения!\n Пометка:\nВозраст должен быть в диапозоне от 0 до 100, a вес больше 0");
            }
            
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}