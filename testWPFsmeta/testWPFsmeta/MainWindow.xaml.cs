using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public BindingList<SmetaModel> _smetaDataList;
        //private BindingList<SmetaModel> _smetaDataList;
        public MainWindow()
        {
            InitializeComponent();
        }
        public class Info
        {
            public string Name { get; set; }
            public string Age { get; set; }
        }
        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            _smetaDataList = new BindingList<SmetaModel>() // по сути пустой лист
            {
                new SmetaModel(){},
            };
            dgSmeta.ItemsSource = _smetaDataList;
            dgSmet.ItemsSource = _smetaDataList;

         // ЗАВЕРНУТЬ В КНОПКУ НАЧАЛО

            // создание итема в дереве
            TreeViewItem item = new TreeViewItem();
            item.Header = "asds";
            item.Name = "item_name";
            dgTree.Items.Add(item);

            // создание датагрида
            var nameBinding = new Binding("Name")
            {
                Mode = BindingMode.Default,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };
            var ageBinding = new Binding("Age")
            {
                Mode = BindingMode.Default,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };
            var dataGrid = new DataGrid();
            dataGrid.AutoGenerateColumns = false;
            dataGrid.Columns.Add(new DataGridTextColumn
            {
                Header = "Name",
                Binding = nameBinding
            });
            dataGrid.Columns.Add(new DataGridTextColumn
            {
                Header = "Age",
                Binding = ageBinding
            });
            dataGrid.ItemsSource = new ObservableCollection<Info>
            {
                new Info
                {
                    Name = "Name 1",
                    Age = "100"
                }
            };

            item.Items.Add(dataGrid);
        // ЗАВЕРНУТЬ В КНОПКУ КОНЕЦ

        }







    }
}

  

