using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class SingleLinkList
    {
        private int length;
        private SingleNode firstElement;

        public SingleLinkList()
        {
            length = 0;
        }

        public void Add(string value)
        {
            var newNode = new SingleNode(value);
            if (length == 0)
            {
                firstElement = newNode;
                length++;
                return;
            }
            FindByPosition(length - 1).NextNode = newNode;
            length++;
        }

        public void Delete(string value)
        {
            length--;
            var nodeToDelete = Find(value);
            if (nodeToDelete == firstElement)
            {
                firstElement = nodeToDelete.NextNode;
                return;
            }
            var previousNode = FindNodeBefore(value);
            if (nodeToDelete.NextNode!=null)
            {
                previousNode.NextNode = nodeToDelete.NextNode;
            }
        }

        public SingleNode Find(string value)
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

        public SingleNode FindNodeBefore(string value)
        {
            var node = firstElement;

            for (int i = 0; i < length; i++)
            {
                if (node.NextNode.Value == value)
                {
                    return node;
                }
                node = node.NextNode;
            }
            return null;
        }

        public SingleNode FindByPosition(int position)
        {
            if (position > length)
            {
                return null;
            }
            var node = firstElement;
            for (int i = 0; i < position; i++)
            {
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
}
