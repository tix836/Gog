using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using testWPFsmeta.Models;

namespace testWPFsmeta
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BindingList<SmetaModel> _smetaData;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            _smetaData = new BindingList<SmetaModel>()
            {
                new SmetaModel(){ Name = "Покраска", Count = 4, Cost = 100 },
                new SmetaModel(){ Name = "Шпаклевка", Count = 6, Cost = 120 }
            };
            dgSmeta.ItemsSource = _smetaData;
        }
    }
    
}
