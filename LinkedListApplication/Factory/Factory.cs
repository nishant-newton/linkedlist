using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedListApplication
{
    static class Factory
    {
        #region Public Static Methods

        public static ILinkList GetLinkListInstance()
        {
            return new LinkedList();
        }

        #endregion

    }
}
