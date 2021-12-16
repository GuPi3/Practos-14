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
using System.Windows.Shapes;

namespace практическая_работа__2
{
    /// <summary>
    /// Логика взаимодействия для Password.xaml
    /// </summary>
    public partial class Password : Window
    {
        private string _Password { get; set; }
        public bool _Auth { get; set; }
        public Password()
        {
            InitializeComponent();
            _Password = "123";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (passBox.Text == _Password)
            {
                _Auth = true;
                Close();
            }
            else MessageBox.Show("Неверный пароль");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
