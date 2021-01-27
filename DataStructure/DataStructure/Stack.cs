using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Stack
    {
        public List<string> MyStack { get; private set; }
        public bool ifNullFlag = false;

        public Stack()
        {
            MyStack = new List<string>();
        }

        public void Push(string value)
        {
            MyStack.Add(value);
        }

        public string Pop()
        {
            string popValue = "";
            if (MyStack.Count == 0)
            {
                ifNullFlag = true;
                return "";
            }
            popValue = MyStack[MyStack.Count - 1];
            MyStack.RemoveAt(MyStack.Count - 1);
            return popValue;
        }
    }
}
