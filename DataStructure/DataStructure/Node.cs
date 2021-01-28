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
        }
    }
}
