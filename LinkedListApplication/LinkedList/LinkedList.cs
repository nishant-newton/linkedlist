using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedListApplication
{
   public class LinkedList : ILinkList
    {
        #region Private Variables
        
        private INode head;
        private INode current;
        private int size;

        #endregion

        #region Constructor

        public LinkedList()
        {
            size = 0;
            head = null;
        }

        #endregion

        #region Class Properties

        public INode GetHeadNode
        {
            get
            {
                return head;
            }
        }

        #endregion

        #region Public Methods
        /// <summary>
        /// Adds the value in the linked list in sequential order
        /// </summary>
        /// <param name="content">value that needs to be added in the linked list</param>
        public void Add(object content)
        {
            size++; //not used size variable to identify the size of the linked list.

            try
            {
                var node = new Node()
                {
                    Data = content
                };

                if (head == null)
                {
                    // This is the first node. Make it head node
                    head = node;
                }
                else
                {
                    // This is not head Node. Make it current's next node.
                    current.Next = node;
                }

                // Makes newly added node the current node
                current = node;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }                     
            
        }

        /// <summary>
        /// Finds the value at nth position from tail in the Linked List
        /// </summary>
        /// <param name="position">nth position</param>
        /// <param name="errorMessage">Contains the errormessage from this method</param>
        /// <returns></returns>
        public INode GetNthNode(int position, out string errorMessage)
        {
            errorMessage = string.Empty;
            try
            {
                if (head == null)
                {
                    errorMessage = "Node is null. Please add some Data in Linked List";
                    return null;
                }
                if (position < 1)
                {
                    errorMessage = "Please locate the value of node with greater value than provided";
                }

                var node1 = head;
                var node2 = head;
                for (int i = 0; i < position; i++)
                {
                    if (node2 == null)
                    {
                        errorMessage = "Linked list size is smaller than the value :" + position;
                        return null;
                    }
                    node2 = node2.Next;

                }
                while (node2 != null)
                {
                    node1 = node1.Next;
                    node2 = node2.Next;
                }
                if (node1 == null)
                {
                    errorMessage = "Node has become empty. Please check that Linked List contains value";
                    return null;
                }
                return node1;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }


        }

        #endregion


    }
}
