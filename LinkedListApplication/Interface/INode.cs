using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedListApplication
{
    public interface INode
    {
        object Data { get; set; }
        Node Next { get; set; }       
    }
}
