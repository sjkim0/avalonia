using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication1.Models
{
    public class MyModel
    {
        public string Name { get; set; }

        public MyModel() 
        { 
            Name = string.Empty;
        }

        public string BussinessLogicReturn()
        {
            return Name;
        }
    }
}
