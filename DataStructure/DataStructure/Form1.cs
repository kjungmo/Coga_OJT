using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructure
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private Queue queue = new Queue();
        private Stack stack = new Stack();
        private LinkedList linkedList = new LinkedList();

        private void enqueue_Click(object sender, EventArgs e)
        {
            string input = valueQueue.Text;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Value none. And spacebar not allowed");
            }
            else
            {
                queue.Enqueue(input);
                displayMyQueue();
                valueQueue.Text = "";
            }
        }

        private void dequeue_Click(object sender, EventArgs e)
        {
            string dequeued = "";
            dequeued += queue.Dequeue();
            if (string.IsNullOrEmpty(dequeued))
            {
                MessageBox.Show("Cannot dequeue, the Queue is empty!");
                showDequeue.Text = "";
            }
            else
            {
                showDequeue.Text = dequeued;
                displayMyQueue();
            }
        }

        private void displayMyQueue()
        {
            List<string> queueToDisplay = queue.MyQueue;
            showQueue.Text = "";
            foreach (string value in queueToDisplay)
            {
                showQueue.Text += value + " ";
                showQueue.Text += " < - ";
            }

        }

        private void push_Click(object sender, EventArgs e)
        {
            string input = valuePush.Text;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Input value to push!");
                return;
            }
            else
            {
                stack.Push(input);
                valuePush.Text = "";
                displayMyStack();
            }
        }

        private void pop_Click(object sender, EventArgs e)
        {
            string popped = "";
            popped += stack.Pop();
            if (string.IsNullOrEmpty(popped))
            {
                MessageBox.Show("Cannot pop, the Stack is empty!");
                showPop.Text = "";
                return;
            }
            else
            {
                showPop.Text = popped;
                displayMyStack();
            }

        }

        private void displayMyStack()
        {
            List<string> stackToDisplay = stack.MyStack;
            showStack.Items.Clear();
            showStack.Items.Add("Top");
            for (int i = stackToDisplay.Count - 1; i >= 0; i--)
            {
                showStack.Items.Add(stackToDisplay[i]);
            }
            showStack.Items.Add("Bottom");
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(createIndex.Text) || string.IsNullOrEmpty(createValue.Text))
            {
                if (string.IsNullOrEmpty(createIndex.Text))
                    MessageBox.Show("Index Needed!");
                else if (string.IsNullOrEmpty(createValue.Text))
                    MessageBox.Show("Value Needed!");
                displayMyLinkedList();
                return;
            }
            int index = Convert.ToInt32(createIndex.Text);
            string created = "";
            created += createValue.Text;
            linkedList.CreateLinkedList(created, index);
            Console.WriteLine(created);
            Console.WriteLine(index);
            displayMyLinkedList();
            createValue.Text = "";
            createIndex.Text = "";

        }

        private void readButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(readIndex.Text))
            {
                MessageBox.Show("Index NEEDED!");
                displayMyLinkedList();
                return;
            }
            int index = Convert.ToInt32(readIndex.Text);
            string read = "";
            readValue.Text = linkedList.ReadNode(index);
            read += readValue.Text;
            if (string.IsNullOrEmpty(read))
                MessageBox.Show("Nothing to read, either Node is none or index is too large!");
            displayMyLinkedList();
            readIndex.Text = "";
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(updateIndex.Text) || string.IsNullOrEmpty(updateValue.Text))
            {
                if (string.IsNullOrEmpty(updateIndex.Text))
                    MessageBox.Show("Index NEEDED!");
                else if (string.IsNullOrEmpty(updateValue.Text))
                    MessageBox.Show("Value NEEDED!");
                displayMyLinkedList();
                return;
            }
            // if both values are input to the textbox
            string updated = updateValue.Text;
            int index = Convert.ToInt32(updateIndex.Text);
            if (linkedList.NumberOfNodes == 0 || index > linkedList.NumberOfNodes || index == 0)
            {
                if (linkedList.NumberOfNodes == 0)
                    MessageBox.Show("There is no node!");
                else if (index > linkedList.NumberOfNodes)
                    MessageBox.Show("Index inappropriate!");
                else if (index == 0)
                    MessageBox.Show("Index ZERO not allowed!");
                updateValue.Text = "";
                updateIndex.Text = "";
                return;
            }
            linkedList.UpdateNode(updated, index);
            displayMyLinkedList();
            updateValue.Text = "";
            updateIndex.Text = "";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (linkedList.NumberOfNodes == 0 || string.IsNullOrEmpty(deleteIndex.Text))
            {
                if (linkedList.NumberOfNodes == 0)
                    MessageBox.Show("No Nodes to delete!");
                else if (string.IsNullOrEmpty(deleteIndex.Text))
                    MessageBox.Show("Index NEEDED!");
                deleteIndex.Text = "";
                displayMyLinkedList();
                return;
            }
            
            int index = Convert.ToInt32(deleteIndex.Text);
            linkedList.DeleteLinkedList(index);
            deleteIndex.Text = "";
            displayMyLinkedList();
        }

        private void displayMyLinkedList()
        {
            Node myNode = linkedList.HeadNode;
            showLinkedList.Items.Clear();
            showLinkedList.Items.Add("Head");
            int counter = linkedList.NumberOfNodes;
            while (counter > 0)
            {
                showLinkedList.Items.Add(myNode.NodeData);
                myNode = myNode.NextNode;
                counter--;
            }
            showLinkedList.Items.Add("Tail");
        }
    }
}
