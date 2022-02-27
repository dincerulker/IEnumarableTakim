using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAIEnumarableTakim
{
    public class TakımEnumarator : IEnumerator
    {
        private readonly Futbolcu[] futbolcular;
        int index = -1;
        public TakımEnumarator(Futbolcu[] futbolcular)
        {
            this.futbolcular = futbolcular;
        }
        public object Current => futbolcular[index];

        public bool MoveNext()
        {
            index++;
            return index < futbolcular.Length;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
