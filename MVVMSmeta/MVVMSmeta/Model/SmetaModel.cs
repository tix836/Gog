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
        
        private Dictionary<string,object> _smetaList;

        public SmetaModel()
        {
            _smetaList = new Dictionary<string, object>();
        }

        public Dictionary<string,object> AddNewCategory(string category)
        {
            var res = new Dictionary<string, object>();
            res.Add(category, null);
            return res;
        }

        public void AddNewTable(string key,Dictionary<string,object> category)
        {
            foreach (KeyValuePair<string, object> entry in category)
            {
                if (entry.Key.Equals(key))
                {
                    category[key] = new List<SmetaItem>();
                }
                else
                {
                    if(entry.Value is object)
                    {
                        if(!entry.Value.GetType().IsArray)
                        {
                            AddNewTable(key,(Dictionary<string,object>)entry.Value);
                        }
                    }
                }
            }
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
