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
        public bool ifNullFlag = false;

        public Queue()
        {
            MyQueue = new List<string>();
        }

        public void Enqueue(string value)
        {
            MyQueue.Add(value);
        }

        public string Dequeue()
        {
            if (MyQueue.Count == 0)
            {
                ifNullFlag = true;
                return "";
            }
            string toDequeue = MyQueue[0];
            MyQueue.RemoveAt(0);
            return toDequeue;
        }

    }
}
