using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class MyArrayList
    {
        private int length;
        private string[] array;

        public MyArrayList(int capacity)
        {
            length = 0;
            array = new string[capacity];
        }

        public void Add(string value)
        {
            length++;
            if (length <= array.Length)
            {
                array[length-1] = value;
                return;
            }
            DoubleArraySize();
            array[length-1] = value;
        }

        public void DoubleArraySize()
        {
            var currentLength = array.Length;
            var newArray = new string[currentLength * 2];
            CopyArrayIntoBiggerArray(array, newArray);
            array = newArray;
        }

        public void CopyArrayIntoBiggerArray(string[] arr1, string[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }
        }

        public void Delete(string value)
        {
            var index=FindPositionByValue(value);
            for (int i = index; i < length-1; i++)
            {
                array[i] = array[i + 1];
            }
                length--;
        }

        public int FindPositionByValue(string value)
        {
            for (int i = 0; i < length; i++)
            {
                if(array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        public string Find(string value)
        {
            for (int i = 0; i < length; i++)
            {
                if (array[i]==value)
                {
                    return value;
                }
            }
            return null;
        }

        public string[] Values()
        {
            return FirstNElements(array, length);
        }

        public string[] FirstNElements(string[] array, int length)
        {
            var returnArray = new string[length];
            for (int i = 0; i < length; i++)
            {
                returnArray[i] = array[i];
            }
            return returnArray;
        }
    }
}
