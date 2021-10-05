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

namespace Var1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int number = Convert.ToInt32(textBox.Text), numb1 = Convert.ToInt32(textBox.Text[0]) - 48, numb2 = Convert.ToInt32(textBox.Text[1]) - 48;
            if (number % 3 == 0)
            {
                label.Content = " да";
            }
            else
                label.Content = " нет";
            if (number % 2 == 0)
            {
                label1.Content = " чётное";
            }
            else
                label1.Content = " нечётное";
            label2.Content =  (numb1 + numb2);
            label3.Content =  (numb1 * numb2);
        }
    }
}
