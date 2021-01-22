using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Queue
    {
        public List<string> MyQueue = new List<string>();

        public Queue()
        {
            return;
        }

        public List<string> Enqueue(string value)
        {
            if (MyQueue.Count == 0)
            {
                MyQueue = new List<string>();
                MyQueue.Add(value);
                return MyQueue;
            }
            MyQueue.Add(value);
            return MyQueue;
        }

        public string Dequeue(List<string> myQueue)
        {
            MyQueue = myQueue;
            if (MyQueue.Count == 0)
            {
                MyQueue = new List<string>();
                return null; 
            }
            string toDequeue = myQueue[0];
            MyQueue.RemoveAt(0);
            return toDequeue;
            
        }

    }
}
