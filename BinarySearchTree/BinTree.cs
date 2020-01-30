using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinTree
    {
        //Member Variables (HAS A)
        Node root;
        Node current;

        //Constructor
        public BinTree()
        {
            root = null;
        }

        //Member Methods (CAN DO)
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (root == null)
            {
                root = newNode;
                current = newNode;
            }
            else
            {
                while (true)
                {
                    // if newNode is greater than previous node check rightChild
                    if (newNode.data > current.data)
                    {
                        if (current.rightChild == null)
                        {
                            current.rightChild = newNode;
                        }
                        else
                        {
                            current = current.rightChild;
                        }
                    }
                    // if newNode is less than previous node check leftChild
                    else if (newNode.data < current.data)
                    {
                        if (current.leftChild == null)
                        {
                            current.leftChild = newNode;
                        }
                        else
                        {
                            current = current.leftChild;
                        }
                    }
                    else
                    {
                        current = root;
                        break;
                    }
                }
            }
        }

        public bool Search(int data)
        {
            current = root;
            while (true)
            {
                if (data == current.data)
                {
                    return true;
                }
                else if (data > current.data)
                {
                    if (current.rightChild == null)
                    {
                        return false;
                    }
                    else
                    {
                        current = current.rightChild;
                    }
                }
                else if (data < current.data)
                {
                    if (current.leftChild == null)
                    {
                        return false;
                    }
                    else
                    {
                        current = current.leftChild;
                    }
                }
            }
        }
    }
}
