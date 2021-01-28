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
        public bool NullChecker { get; private set; }

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
            if (MyStack.Count > 0)
            {
                string popValue = "";
                popValue = MyStack[MyStack.Count - 1];
                MyStack.RemoveAt(MyStack.Count - 1);
                NullChecker = false;
                return popValue;
            }

            NullChecker = true;
            return "";
        }
    }
}
