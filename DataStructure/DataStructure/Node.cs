using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Node
    {
        public string data;
        public Node next;

        public Node(string dataInput)
        {
            data = dataInput;
            next = null;
        }

        // creating new Node
        public void CreateNode(string input)
        {
            //creates a new node when next node is none
            if (this.next == null)
                next = new Node(input);
            else
                next.CreateNode(input);
        }

        // reads specific Node in orders
        public string ReadNode(int index)
        {
            // only when the next node exists
            if (this.next != null)
            {

                Node read = this.next;
                for (int i = 0; i < index; i++)
                {
                    
                }
            }
            
            else
            {
                return this.data;
            }
            //for loop to that index of user's input
        }

        // adds(updates) a Node in specific index
        public Node UpdateNode(int index, string input)
        {

        }

        // deletes where user wants, and gets the value of the deleted index
        public Node DeleteNode()
    }
}
