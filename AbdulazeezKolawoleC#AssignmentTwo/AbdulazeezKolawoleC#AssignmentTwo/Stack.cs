using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazeezKolawoleC_AssignmentTwo
{
    public class Stack
    {
        List<object> items = new List<object>();


        // Push method to add an object to the stack
        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Null values cannot be added to the stack.");

            items.Add(obj);
        }

        public object Pop()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("Cannot pop from an empty stack.");

            int lastObject = items.Count - 1;
            object topObject = items[lastObject];
            items.RemoveAt(lastObject);
            return topObject;
        }

        // Clear method to remove all objects from the stack
        public void Clear()
        {
            items.Clear();
        }
    }
}
