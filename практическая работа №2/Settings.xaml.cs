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
using System.IO;

namespace практическая_работа__2
{
    /// <summary>
    /// Логика взаимодействия для Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (StreamWriter save1 = new StreamWriter(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.ini")))
            {
                try
                {
                    save1.WriteLine(columnsBox.Text);
                    save1.WriteLine(rowsBox.Text);

                }
                catch { MessageBox.Show("Некорректные данные"); }
                Close();
            }
        }
    }
}
