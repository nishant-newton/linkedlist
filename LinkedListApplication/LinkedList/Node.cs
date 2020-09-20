using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedListApplication
{
   public class Node : INode
   {
       #region Class Properties
       
       public object Data { get; set; }
       public Node Next { get; set; }

       #endregion
   }
}
