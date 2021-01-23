using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Stack
    {
        public List<string> MyStack = new List<string>();

        public Stack()
        {
            return;
        }

        public List<string> Push(string value)
        {
            MyStack.Add(value);
            return MyStack;
        }

        public string Pop()
        {
            // when poping a stack, you get the value from the last index of the stack, and delete the last index stack
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
