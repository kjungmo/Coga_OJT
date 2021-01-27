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

        public Stack()
        {

        }

        public void Push(string value)
        {
            if (MyStack == null)
            {
                MyStack = new List<string>();
            }
            MyStack.Add(value);
        }

        public string Pop()
        {
            string popValue = "";
            if (MyStack.Count >= 1)
            {
                popValue = MyStack[MyStack.Count - 1];
                MyStack.RemoveAt(MyStack.Count - 1);
            }
            return popValue;
        }
    }
}
