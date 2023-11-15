using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace işçi_mühendis
{
    internal class muhendis:Personal
    {
        string birim;
        public string Birim
        {
            get { return birim; }
            set => birim = value;
        }
    }
    
}
