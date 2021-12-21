using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsÜbungPolymorphie
{
    internal class Sub : Basis
    {
        public override string Test()
        {
            return "Die Methode Sub.Test() wurde aufgerufen";
        }

        public string Test(string param1)
        {
            return $"Die Methode Sub.Test({param1}) wurde aufgerufen";
        }

        new public string Test(int param2)
        {
            return $"Die Methode Sub.Test({param2}) wurde aufgerufen";
        }
    }
}
