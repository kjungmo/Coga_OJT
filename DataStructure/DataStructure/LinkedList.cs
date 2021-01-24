using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class LinkedList
    {
        public Node MyLinkedListNode;

        public LinkedList()
        {
            MyLinkedListNode = null;
        }

        //public void CreateLinkedNode(string input)
        //{
        //    if (MyLinkedListNode == null)
        //        MyLinkedListNode = new Node(input);
        //    else
        //        MyLinkedListNode.CreateNode(input);
        //}

        public List<Node> MyLinkedList = new List<Node>();

        public List<Node> ChangeIndex(List<Node> linkedlist, int index, string input)
        {
            List<Node> leftList = new List<Node>();
            List<Node> rightList = new List<Node>();
            List<Node> newMyLinkedList = new List<Node>();

            Node indexNode = new Node(index, input);

            for (int i = 0; i < index; i++)
            {
                leftList.Add(MyLinkedList[i]);
            }

            leftList.Add(indexNode);

            for (int i = index + 1; i < MyLinkedList.Count; i++)
            {
                rightList.Add(MyLinkedList[i]);
            }

            return MergeLists(leftList, rightList);
        }

        public List<Node> MergeLists(List<Node> left, List<Node> right)
        {
            for (int i = 0; i < right.Count; i++)
            {
                left.Add(right[i]);
            }
            return left;
        }

        public List<Node> CreateLinkedList(int index, string input)
        {
            if (index - 1 >= 0)
            {
                if (MyLinkedList == null)
                {
                    Node head = new Node(input);
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
