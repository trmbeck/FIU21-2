using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsÜbungPolymorphie
{
    internal class Basis
    {
        public virtual string Test()
        {
            return "Die Methode Basis.Test() wurde aufgerufen";
        }

        public virtual string Test(int param1)
        {
            return $"Die Methode Basis.Test({param1}) wurde aufgerufen";
        }

        public virtual string Test(string param1)
        {
            return $"Die Methode Basis.Test({param1}) wurde aufgerufen";
        }
    }
}
