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

        public Node()
        {
            return;
        }
        // creating new Node at the end of the linkedList
        public void CreateNode(string input)
        {
            //creates a new node when next node is none, when next node is not none, recursive function helps to get to the end node and creates new node
            if (next == null)
                next = new Node(input);
            else
                next.CreateNode(input);

        }

        public string GetNodeData()
        {
            return data;
        }

        //// reads specific Node in orders
        //public string ReadNode(int index)
        //{
        //    // only when the next node exists
        //    if (this.next != null)
        //    {
        //        int count = 0;
        //        for (int i = 0; i < index; i++)
        //        {
        //            if (count == index - 1)
        //                GetNodeData();
        //            else
        //        }
        //        Node read = this.next;
        //        for (int i = 0; i < index; i++)
        //        {
                    
        //        }
        //    }
            
        //    else
        //    {
        //        return this.data;
        //    }
        //    //for loop to that index of user's input
        //}
        
    }
}
