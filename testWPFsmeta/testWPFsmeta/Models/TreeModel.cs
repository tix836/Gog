using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testWPFsmeta.Models
{
    class TreeModel
    {
        

        class TreeModel1: INotifyPropertyChanged
        {
            public string NameTree { get; set; }

            public event PropertyChangedEventHandler PropertyChanged;
        }
    }
}
