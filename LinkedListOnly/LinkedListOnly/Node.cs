using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListOnly
{
    public class Node
    {
        public string NodeData { get; set; }
        public Node NextNode { get; set; }

        public Node(string dataInput)
        {
            NodeData = dataInput;
            NextNode = null;
        }

        public Node()
        {
        }
    }
}
