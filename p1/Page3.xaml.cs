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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int K = int.Parse(AA.Text);
            int d = (K - 1) % 7 + 1;
            string da = "";
            switch (d)
            {
                case 1: da = "Понедельник"; break;
                case 2: da = "Вторник"; break;
                case 3: da = "Среда"; break;
                case 4: da = "Четверг"; break;
                case 5: da = "Пятница"; break;
                case 6: da = "Суббота"; break;
                case 7: da = "Воскресенье"; break;
            }
            Rezult.Text = $"Ответ: {da}";
        }
    }
}
