using System;
using System.Data;
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

namespace WpfApp17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] mas;//Описываем массив как глобальный элемент


        public MainWindow()
        {
            InitializeComponent();

        }

        // Выход
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // О программе
        private void Prog2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ввести n целых чисел. Найти сумму чисел > 15. Результат вывести на экран.");
        }

        // Создание массива
        private void miCreate_Click(object sender, RoutedEventArgs e)

        {

            //Получаемм количество ячеек в массиве
            int count = Convert.ToInt32(tbCount.Text);
            mas = new int[count];
            for (int i = 0; i < count; i++)
                //Выводим массив на форму
                dataGrid.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;

        }

        // Заполнение массива
        private void miFill_Click(object sender, RoutedEventArgs e)
        {
            if (mas == null)
            {
                MessageBox.Show("Сначала создайте массив.");
                return;
            }
            //Получаем количество ячеек в массиве
            int count = Convert.ToInt32(tbCount.Text);
            //Получаем диапозон случайных чисел
            int max = Convert.ToInt32(randMax.Text);
            mas = new int[count];//Создаем массив
            Random rnd = new Random();
            //Заполняем таблицу случайными значениями
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(max);
                //Выводим массив на форму
                dataGrid.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
            }
            tbRez.Text = "";


        }

        // Очистка
        private void miClear_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = null;
            mas = null;
            tbRez.Text = "";
        }

        // Решение (сумма чисел >15)
        private void miCalc_Click(object sender, RoutedEventArgs e)
        {
            if (mas == null || mas.Length == 0)
            {
                MessageBox.Show("Сначала создайте и заполните массив.");
                return;
            }

            int sum = 0;
            // Проходим по каждому элементу массива 'mas'
            foreach (int val in mas)
                if (val > 15)
                    sum += val;

            tbRez.Text = sum.ToString(); // Ввывод ответа
        }


    }
}