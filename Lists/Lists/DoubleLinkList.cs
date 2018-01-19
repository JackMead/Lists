using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class DoubleLinkList
    {
        private int length;
        private DoubleNode firstElement;
        private DoubleNode lastElement;

        public DoubleLinkList()
        {
            length = 0;
        }

        public void Add(string value)
        {
            var newNode = new DoubleNode(value, lastElement);
            if (lastElement != null)
            {
                lastElement.NextNode = newNode;
            }
            lastElement = newNode;
            length++;

            if (length == 1)
            {
                firstElement = newNode;
            }
        }

        public void Delete(string value)
        {
            length--;
            var nodeToDelete = Find(value);
            var previousNode = nodeToDelete.PreviousNode;
            var nextNode = nodeToDelete.NextNode;
            if (previousNode != null)
            {
                previousNode.NextNode = nextNode;
            }
            else
            {
                firstElement = nextNode;
            }
            if (nextNode != null)
            {
                nextNode.PreviousNode = previousNode;
            }
            else
            {
                lastElement = previousNode;
            }
        }

        public DoubleNode Find(string value)
        {
            var node = firstElement;

            for (int i = 0; i < length; i++)
            {
                if (node.Value == value)
                {
                    return node;
                }
                node = node.NextNode;
            }
            return node;
        }

        public string[] Values()
        {
            var values = new string[length];
            var node = firstElement;
            for (int i = 0; i < length; i++)
            {
                values[i] = node.Value;
                node = node.NextNode;
            }
            return values;
        }
    }

    public class DoubleNode
    {
        public string Value { get; }
        public DoubleNode NextNode { get; set; }
        public DoubleNode PreviousNode { get; set; }

        public DoubleNode(string value, DoubleNode previousNode)
        {
            Value = value;
            PreviousNode = previousNode;
            NextNode = null;
        }
    }

}
