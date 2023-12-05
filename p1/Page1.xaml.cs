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

namespace p1
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int A = int.Parse(AA.Text);
            int A1 = A / 100;
            int A2 = A / 10 % 10;
            int A3 = A % 10;
            Rezult.Text = $"Ответ: Сумма = {A1 + A2 + A3} Произведение {A1 * A2 * A3}";
        }
    }
}
