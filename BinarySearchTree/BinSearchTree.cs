using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinSearchTree
    {
        //Member Variables (HAS A)
        Node start;
        Node recent;

        //Constructor
        public BinSearchTree()
        {
            start = null;
        }

        //Member Methods (CAN DO)
        public void Add(int data)
        {
            Node node = new Node(data);
            if (start == null)
            {
                start = node;
            }
            else
            {
                Node current = start;
                
            }
        }

    }
}
