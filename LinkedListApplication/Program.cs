using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedListApplication
{
    class Program
    {
        #region Static Void Method

        /// <summary>
        /// This is the entry point of the application. 
        /// Takes input from user in a comma separated string to create the link list
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string errorMessage = string.Empty;
            int position = 5;            
            string input = string.Empty;
            
            while (true)
            {
                try
                {
                    List<int> linklistsValue = new List<int>(); //This list will hold the values that user entered from console
                    while (true)
                    {
                        Console.WriteLine("Please enter Linked List value. Values should be comma separated");
                        input = Console.ReadLine();
                        bool validate = true;
                        if (string.IsNullOrEmpty(input))
                        {
                            Console.WriteLine("Input is empty. Please enter again");
                            validate = false;
                        }
                        else
                        {
                            var inputArray = input.Split(',');

                            foreach (var inputChar in inputArray)
                            {
                                int value = int.Parse(inputChar); //In case of error it will throw the exception
                                linklistsValue.Add(value);                                                                
                            }
                        }
                        if (validate)
                            break;
                    } //end of inner while

                    var linkedList = Factory.GetLinkListInstance(); //Calling the Factory class to get the instance of Linked List class

                    foreach (var linklist in linklistsValue) //iterate through the values of List which user entered
                    {
                        linkedList.Add(linklist); //Creating the Link List from the values entered by user by calling Add method of LinkedList class
                    }

                    Console.WriteLine("Linked List succesfully Created. Size of Linked List is :" + linklistsValue.Count);
                    var headNode = linkedList.GetHeadNode; //Getting the First Node
                    var node = linkedList.GetNthNode(position, out errorMessage); // Getting the value of nth node from tail in linked list
                    Console.WriteLine(CreateNthNodeOutput(node, position, errorMessage)); //This method creates the output string
                    Console.WriteLine(CreateListNodesOutput(headNode));//This method creates the output string               
                    Console.WriteLine("Press r to start again. Any other key to exit");
                    var key = Console.ReadKey().KeyChar;
                    if (!Char.Equals(key, 'r'))
                        break;
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Application has encountered an error : " + ex.Message); //001 is the error code to identify the method where the error occured
                    Console.WriteLine("Press r to start again. Any other key to exit");
                    var key = Console.ReadKey().KeyChar;
                    if (!Char.Equals(key, 'r'))
                        break;
                    Console.Clear();
                }
            } //end of outer while
            
            
        }

        #endregion

        #region Private Static Methods

        /// <summary>
        /// Generates the output string which is shown in the console.
        /// The string contains the value of the nth node from tail in the linked list
        /// </summary>
        /// <param name="node">nth node from tail</param>
        /// <param name="position">this the position of the node</param>
        /// <param name="errorMessage">Any error that occured while fetching the value of nth node from tail</param>
        /// <returns>Output string</returns>
        private static string CreateNthNodeOutput(INode node, int position, string errorMessage)
        {
            string result = string.Empty;
            if (node == null)
                result = "Application has encountered an error (002): " + errorMessage; //002 is the error code to identify the method where the error occured
            else
            result = String.Format(@"Value of Node at location {0} from end is {1}", position, node.Data.ToString());
            return result;
        }

        /// <summary>
        /// Generates the output string which shows all the value in the linked list
        /// </summary>
        /// <param name="headNode">First node in the linked list</param>
        /// <returns>Output string</returns>
        private static string CreateListNodesOutput(INode headNode)
        {
            var result = new StringBuilder();
            while (headNode != null)
            {
                if (result.Length > 0)
                    result.Append("->");
                result.Append(headNode.Data.ToString());
                headNode = headNode.Next;

            }
            return "Linked List : " + result.ToString();
        }

        #endregion
    }
}
