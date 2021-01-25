using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Queue
    {
        public List<string> MyQueue { get; private set; }
        public Queue()
        {
            MyQueue = null;
        }

        public void Enqueue(string value)
        {
            if (MyQueue == null)
            {
                MyQueue = new List<string>();
            }
            MyQueue.Add(value);
        }

        public string Dequeue()
        {
            if (this.MyQueue.Count == 0)
            {
                this.MyQueue = new List<string>();
            }
            string toDequeue = MyQueue[0];
            this.MyQueue.RemoveAt(0);
            return toDequeue;
        }

    }
}
