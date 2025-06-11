using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp10
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
         int[] mas;

        // Выход
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // Справка
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Environment.NewLine + "Ввести n целых чисел. Найти сумму чисел >15. Результат вывести на экран.");
        }

        // Создание массива
        private void Rasch_Click(object sender, RoutedEventArgs e)
        {
            int count = Convert.ToInt32(Tabl);
            mas = new int[count];
            Tabl.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
        }



        // Заполнение массива
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //получание диапозон 
            int randMax = Convert.ToInt32(Tabl);
            // количество ячеек
            int Count = Convert.ToInt32(Tabl);
        }

        // Очистка
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Tabl = null;
            mas = null;

        }

        // Расчёт суммы чисел меньше 15
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            int sum = 0;
            if (mas != null)
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] < 15)
                        sum += mas[i];
                }
                tbRez.Text = sum.ToString();
            }
        }

        private void Prog2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

