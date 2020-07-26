using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVMSmeta.Model
{
    class SmetaItem
    {
        public SmetaItem()
        {
            this.Name = "";
            this.Amount = 0;
            this.Price = 0;
        }
        private string Name { get; set; }
        private int Amount { get; set; }
        private double Price { get; set; }
    }
}
