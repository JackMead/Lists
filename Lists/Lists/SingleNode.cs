using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class SingleNode
    {
        public SingleNode NextNode { get; set; }
        public string Value {get;}

        public SingleNode(string value)
        {
            Value = value;
            NextNode = null;
        }
    }
}
