using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testWPFsmeta.Models
{
    class SmetaModel
    {
        public string Name { get; set; }
        private int _Count;
        private int _Cost;
        
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
        
        public int Cost
        {
            get { return _Cost; }
            set { _Cost = value; }
        }


    }
}
