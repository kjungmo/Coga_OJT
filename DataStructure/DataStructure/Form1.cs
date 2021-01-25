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
        //private LinkedListNode linkedList = new LinkedListNode();

        private void enqueue_Click(object sender, EventArgs e)
        {
            string input = valueQueue.Text;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Value none. And spacebar not allowed");
                return;
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
            if (queue.MyQueue.Count == 0)
            {
                MessageBox.Show("Cannot dequeue, the Queue is empty!");
                showDequeue.Text = "";
                return;
            }
            dequeued += queue.Dequeue();
            showDequeue.Text = dequeued;
            displayMyQueue();
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
            if (stack.MyStack.Count == 0)
            {
                MessageBox.Show("Cannot pop, the Stack is empty!");
                showPop.Text = "";
                return;
            }
            popped += stack.Pop();
            showPop.Text = popped;
            displayMyStack();
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

        }

        private void readButton_Click(object sender, EventArgs e)
        { 

        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void displayMyLinkedList()
        {

        }
    }
}
