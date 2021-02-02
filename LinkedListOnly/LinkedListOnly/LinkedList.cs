using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListOnly
{
    public class LinkedList
    {
        public Node HeadNode { get; private set; }
        public int NumberOfNodes { get; private set; } // indicates how many nodes exists and count + 1 is the number of total nodes

        public LinkedList()
        {
        }

        // 3 types of adding ( in front, at the back, in the middle ) 
        public void CreateLinkedList(string dataInput, int index) 
        {
            if (NumberOfNodes == 0 || index == 0) // when there are no nodes + index = 1 meaning in the front
                AddToHead(dataInput);
            else if (NumberOfNodes < index) // when index is out of range add at the back of the list
                AddToTail(dataInput);
            else 
            {
                AddInBetween(dataInput, index);
            }
        }

        // to add a node between two existing nodes
        public void AddInBetween(string inputData, int index)
        {
            Node newNode = new Node(inputData); 
            Node temp = HeadNode;
            int counter = 0;
            while (counter < index - 1)  
            {
                temp = temp.NextNode;
                counter++;
            }
            newNode.NextNode = temp.NextNode;
            temp.NextNode = newNode;
            NumberOfNodes++;
        }
        
        // to add a node at the tail of the linked list
        public void AddToTail(string inputData)
        {
            Node newNode = new Node(inputData);
            Node temp = HeadNode;
            int counter = 0;
            while (counter < (NumberOfNodes - 1))
            {
                temp = temp.NextNode;
                counter++;
            }
            temp.NextNode = newNode; 
            NumberOfNodes++;
        }

        // to add a node in front of the linked list
        public void AddToHead(string inputData)
        {
            if (HeadNode == null)
            {
                HeadNode = new Node(inputData);
                NumberOfNodes++;
                return;
            }
            Node temp = new Node(inputData);
            temp.NextNode = HeadNode;
            HeadNode = temp;
            NumberOfNodes++;
        }

        // to read a node according to the index input 
        public string ReadNode(int index) // where > 0
        {
            Node readTarget = HeadNode;
            int counter = 0;
            string readNodeData = "";

            if (NumberOfNodes == 0 || NumberOfNodes < index) // if user-targeted value index is out of range
            {
                return readNodeData;
            }
            while (counter != index)
            {
                readTarget = readTarget.NextNode;
                counter++;
            }
            return readTarget.NodeData;
        }

        public void UpdateNode(string dataInput, int index)
        {
            Node temp = HeadNode;
            int counter = 0;
            while (counter < (index - 1))
            {
                temp = temp.NextNode;
                counter++;
            }
            temp.NodeData = dataInput;
        }

        public void DeleteLinkedList(int index)
        {
            if (NumberOfNodes == 0)
                HeadNode = null;
            else if (index == 1)
                DeleteAtHead();
            else if (NumberOfNodes < index)
                DeleteAtTail();
            else
            {
                DeleteInBetween(index);
            }
        }

        public void DeleteAtHead()
        {
            Node changedByDeletion = HeadNode.NextNode;
            HeadNode = null;
            HeadNode = changedByDeletion;
            NumberOfNodes--;
        }

        public void DeleteAtTail()
        {
            Node changedByDeletion = HeadNode;
            while (changedByDeletion.NextNode.NextNode != null)
            {
                changedByDeletion = changedByDeletion.NextNode;
            }
            changedByDeletion.NextNode = null;
            NumberOfNodes--;
        }

        public void DeleteInBetween(int index)
        {
            Node nodeToBeLinked = new Node();
            Node temp = HeadNode;
            int counter = 1;
            while (counter < (index - 1))
            {
                temp = temp.NextNode;
                counter++;
            }
            nodeToBeLinked = temp.NextNode.NextNode;
            temp.NextNode = null;
            temp.NextNode = nodeToBeLinked;
            NumberOfNodes--;
        }


    }
}
