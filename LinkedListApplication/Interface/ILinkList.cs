using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedListApplication
{
   public interface ILinkList
    {
        void Add(object obj);
        INode GetNthNode(int position, out string errorMessage);        
        INode GetHeadNode { get; }
        
    }
}
