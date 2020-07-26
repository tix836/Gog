using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMSmeta.Model
{
    public class SmetaModel
    {
        //нужно переделать модель, не подходит для хранения данных
        private List<ObservableCollection<SmetaItem>> _smetaList;
        public SmetaModel()
        {
            _smetaList = new List<ObservableCollection<SmetaItem>>();
        }
        public void AddNewCategory()
        {
            _smetaList.Add(new ObservableCollection<SmetaItem>());
        }
        public void SaveListToExcelFile()
        {

        }
        public void SaveListToJsonFile()
        {

        }
        public void LoadListFromJsonFile()
        {
            
        }
        
    }
}
