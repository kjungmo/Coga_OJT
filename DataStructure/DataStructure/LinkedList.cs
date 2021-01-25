﻿using System;
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

            Node indexNode = new Node(input);

            for (int i = 0; i < index; i++)
            {
                leftList.Add(linkedlist[i]);
            }

            leftList.Add(indexNode);

            for (int i = index + 1; i < linkedlist.Count; i++)
            {
                rightList.Add(linkedlist[i]);
            }

            return MergeLists(leftList, rightList);
        }

        public List<Node> MergeLists(List<Node> left, List<Node> right)
        {
            if (right != null)
            {
                for (int i = 0; i < right.Count; i++)
                {
                    left.Add(right[i]);
                }
            }
            return left;
        }

        public List<Node> CreateLinkedList(string indexText, string input)
        {
            int index = Convert.ToInt32(indexText);
            if (MyLinkedList == null)
            {
                Node head = new Node();
                MyLinkedList.Add(head); // mylinkedlist[0] is head node
                Node inputNode = new Node(input);
                MyLinkedList.Add(inputNode);
                return MyLinkedList; // mylinkedlist[1] exists, and that becomes the first Linked Node 
            }

            else if (MyLinkedList[index] != null)
            {

                MyLinkedList = ChangeIndex(MyLinkedList, index, input);
                return MyLinkedList;
            }

            else
                return MyLinkedList;

        }

        public string ReadLinkedList(string indexText)
        {
            int index = Convert.ToInt32(indexText);
            return MyLinkedList[index].data;
        }

        public List<Node> UpdateLinkedList(string indexText, string input)
        {
            int index = Convert.ToInt32(indexText);
            string newInput = input;
            MyLinkedList[index].data = newInput;
            return MyLinkedList;
        }

        public string DeleteLinkedList(string indexText)
        {
            int index = Convert.ToInt32(indexText);
            string deleteNode = MyLinkedList[index].data;
            MyLinkedList.RemoveAt(index);
            return deleteNode;
        }
    }
}
