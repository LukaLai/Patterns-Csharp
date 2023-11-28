using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    interface ICafe
    {
        int GetPrix();
        string GetDescription();
    }

    class SimpleCafe : ICafe
    {
        public int GetPrix()
        {
            return 2;
        }

        public string GetDescription()
        {
            return "Simple cafe";
        }
    }
}