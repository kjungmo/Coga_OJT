using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class LinkedList
    {
        //public Node MyLinkedListNode;

        //public LinkedList()
        //{
        //    MyLinkedListNode = null;
        //}

        //public void CreateLinkedNode(string input)
        //{
        //    if (MyLinkedListNode == null)
        //        MyLinkedListNode = new Node(input);
        //    else
        //        MyLinkedListNode.CreateNode(input);
        //}

        public List<Node> MyLinkedList = new List<Node>();

        public List<Node> CreateLinkedList(int index, string input)
        {
            if (index - 1 >= 0)
            {
                if (MyLinkedList == null)
                {
                    Node head = new Node();
                    MyLinkedList.Add(head); // mylinkedlist[0] is head node
                    return MyLinkedList;
                }

                else if (MyLinkedList[index - 1] != null)
                {
                    //Node temp = new Node(index, input);
                    //MyLinkedList.Add(temp);
                    //temp.next = MyLinkedList[0];
                    //MyLinkedList[0] = temp;
                    //return MyLinkedList;
                    Node temp = new Node(index - 1, input);
                    //MyLinkedList[index - 1];
                    Node toSwap = new Node();
                    MyLinkedList.Add(toSwap);
                    for (int i = MyLinkedList.Count - 2; i > index - 1; i--)
                    {
                        
                        Node swapHelper = new Node();
                        swapHelper = toSwap;
                        toSwap = MyLinkedList[i];
                        MyLinkedList[i] = swapHelper;
                    }

                }
                else
                {

                }
            }
            return MyLinkedList;

        }
    }
}
