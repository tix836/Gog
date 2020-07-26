using MVVMSmeta.Model;
using MVVMSmeta.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace MVVMSmeta.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private SmetaModel _smeta;
        public SmetaModel Smeta
        {
            get
            {
                return _smeta;
            }
            set
            {
                _smeta = value;
            }
        }
        private string _categoryTitle;
        public string CategoryTitle
        {
            get=>_categoryTitle;
            set => SetField(ref _categoryTitle, value);
        }
        public MainWindowViewModel()
        {
            this.Smeta = new SmetaModel();
        }
        private ICommand _commandAddNewTreeViewItem;
        public ICommand CommandAddNewTreeViewItem
        {
            get
            {
                if (_commandAddNewTreeViewItem == null)
                {
                    _commandAddNewTreeViewItem = new ICommandAddNewTreeViewItem
                    (
                        p=>CanAddNewTreeViewItem(),
                        p => this.AddNewTreeViewItem()
                    );

                }
                return _commandAddNewTreeViewItem;
            }
        }

        private bool CanAddNewTreeViewItem()
        {
            if (!String.IsNullOrEmpty(CategoryTitle))
            {
                return true;
            }
            
            return false;
        }


        
        public void AddNewTreeViewItem()
        {

            //TreeViewItem item = new TreeViewItem();
            //item.Header = CategoryTitle;
            //item.Name = "item_name";
            ////dgTree.Items.Add(item);

            //// создание датагрида
            //var nameBinding = new Binding("Name")
            //{
            //    Mode = BindingMode.Default,
            //    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            //};
            //var amountBinding = new Binding("Amount")
            //{
            //    Mode = BindingMode.Default,
            //    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            //};
            //var priceBinding = new Binding("Price")
            //{
            //    Mode = BindingMode.Default,
            //    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            //};
            //var dataGrid = new DataGrid();
            //dataGrid.AutoGenerateColumns = false;
            //dataGrid.Columns.Add(new DataGridTextColumn
            //{
            //    Header = "Имя",
            //    Binding = nameBinding
            //});
            //dataGrid.Columns.Add(new DataGridTextColumn
            //{
            //    Header = "Количество",
            //    Binding = amountBinding
            //});
            //dataGrid.Columns.Add(new DataGridTextColumn
            //{
            //    Header = "Цена",
            //    Binding = priceBinding
            //});

        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
           => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
