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
using ToysLibrary;

namespace ToysLibraryWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Book book;
        string t;
        string a;
        bool i;
        string p;
        int y;

        public MainWindow()
        {
            t = TB_title.Text;
            a = TB_author.Text;
            i = Convert.ToBoolean(Convert.ToInt32(TB_author.Text));
            p = TB_publisher.Text;
            y = int.Parse(TB_year.Text);
            InitializeComponent();
            book = new Book(t, a, i, p, y);
        }

        private void ToysLibrary_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { 
        }
    }
}
