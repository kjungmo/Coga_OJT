﻿using System;
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
        Queue queue;
        Stack stack;

        public Form1()
        {
            InitializeComponent();
            queue = new Queue();
            stack = new Stack();
        }

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
            if (queue.MyQueue.Count == 0)
                MessageBox.Show("Cannot dequeue, the Queue is empty!");
            string dequeued = "";
            List<string> toDequeue = queue.MyQueue;
            dequeued += queue.Dequeue(toDequeue);
            showDequeue.Text = dequeued;
            displayMyQueue();
            //if (string.IsNullOrEmpty(showDequeue.Text))
            //{
            //    MessageBox.Show("No value to dequeue!");
            //    return;
            //}
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
    }
}
