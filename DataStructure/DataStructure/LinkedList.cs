using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class LinkedList
    {
        public Node HeadNode { get; private set; }
        public int NumberOfNodes { get; private set; } // indicates how many nodes exists and count + 1 is the number of total nodes
        public string ValueReturned { get; private set; }

        public LinkedList()
        {
            HeadNode = null;
            NumberOfNodes = 0;
        }

        public void CreateLinkedList(string dataInput, int index)
        {
            if (NumberOfNodes == 0)
                HeadNode = new Node(dataInput);
            if (index == 1)
                AddToHead(dataInput);
            else if (NumberOfNodes < index)
                AddToTail(dataInput);
            else
            {
                AddInBetween(dataInput, index);
            }
        }

        public void AddInBetween(string inputData, int index)
        {
            Node newNode = new Node(inputData);
            Node temp = HeadNode;
            int counter = 0;
            while (counter < index)
            {
                if (counter == index - 2)
                {
                    newNode.NextNode = temp.NextNode;
                    temp.NextNode = newNode;
                    return;
                }
                temp = temp.NextNode;
                counter++;
            }
            NumberOfNodes++;
        }
        public void AddToTail(string inputData)
        {
            HeadNode.AddToTail(inputData);
            NumberOfNodes++;
        }
        public void AddToHead(string inputData)
        {
            Node temp = new Node(inputData);
            temp.NextNode = HeadNode;
            HeadNode = temp;
            NumberOfNodes++;
        }

        public void PrintList()
        {
            Node runner = HeadNode; // equal to front of my list
            while (runner != null)
            {
                string dodo = runner.NodeData;
                runner = runner.NextNode;

            }
        }

        public string ReadNode(int index) // where > 0
        {
            Node readTarget = HeadNode;
            int counter = 1;
            string readNodeData = "";

            if (NumberOfNodes == 0 || NumberOfNodes < index) // if user-targeted value index is out of range
                return readNodeData;
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
            int counter = 1;
            if (NumberOfNodes == 0 || NumberOfNodes < index)
                return;
            while (counter <= index)
            {
                temp = temp.NextNode;
                counter++;
            }
            temp.NodeData = dataInput;
        }

        public string DeleteNode(int index)
        {
            Node deleteTarget = HeadNode;
            int counter = 1;
            string deleteNodeData = "";

            if (NumberOfNodes == 0 || NumberOfNodes < index) // if user-targeted value index is out of range
                return deleteNodeData; // must chech isNullorEmpty at form.cs
            while (counter != index)
            {
                deleteTarget = deleteTarget.NextNode;
                counter++;
            }
            deleteNodeData += deleteTarget.NodeData;

            return deleteNodeData;
        }

        public void DeleteAtHead()
        {
            Node changedByDeletion = HeadNode.NextNode;
            HeadNode.NextNode = null;
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
            Node toDelete = new Node();
            Node temp = HeadNode;
            int counter = 1;
            while (counter < index)
            {
                temp = temp.NextNode;
                counter++;
            }
            toDelete = temp.NextNode.NextNode;
            temp.NextNode.NextNode = null;
            temp.NextNode = toDelete;
            NumberOfNodes--;
        }


    }
}
