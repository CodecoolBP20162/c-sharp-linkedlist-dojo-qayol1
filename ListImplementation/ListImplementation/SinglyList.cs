using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListImplementation
{
    public class SinglyList<T>
    {
        
        private class Node
        {
            public Node Next;
            public T Data;
        }

        private Node head;

        public void Add(T data)
        {
            Node toAdd = new Node();
            toAdd.Data = data;
            if (head != null)
            {
                head = toAdd;
            } else
            {
                Node current = head;
                current.Next = toAdd;
            }
            
        }
    }
}
