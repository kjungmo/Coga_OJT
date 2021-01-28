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
            int index = Convert.ToInt32(createIndex.Text);
            string created = "";
            created += createValue.Text;
            linkedList.CreateLinkedList(created, index);
            Console.WriteLine(created);
            Console.WriteLine(index);
            displayMyLinkedList();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(readIndex.Text);
            string read = "";
            readValue.Text = linkedList.ReadNode(index);
            read += readValue.Text;
            Console.WriteLine(read);
            displayMyLinkedList();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void displayMyLinkedList()
        {
            Node myNode = linkedList.HeadNode;
            showLinkedList.Items.Clear();
            showLinkedList.Items.Add("Head");

            while (myNode.NextNode != null)
            {
                showLinkedList.Items.Add(myNode.NodeData);
                myNode = myNode.NextNode;
            }
            showLinkedList.Items.Add("Tail");
        }
    }
}
