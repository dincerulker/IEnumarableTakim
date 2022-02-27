using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAAracHiz
{
    public class CezaEventArgs : EventArgs
    {
        public decimal CezaTutari { get; private set; }
        public DateTime CezaTarihi { get; private set; }
        public CezaEventArgs(DateTime cezaTarihi, decimal cezaTutari)
        {
            CezaTarihi = cezaTarihi;
            CezaTutari = cezaTutari;
        }
    }
}
