using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class NewClass
    {
        public string Name
        {
            get;
            set;
        }
        private void SetName(string name)
        {
            Name = name;
        }
    }
}
