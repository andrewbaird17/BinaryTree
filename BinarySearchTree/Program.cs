using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinTree BST = new BinTree();
            BST.Add(50);
            BST.Add(35);
            BST.Add(75);
            BST.Add(20);
            BST.Add(40);
            BST.Add(60);
            BST.Add(95);
            BST.Add(100);


            bool success = BST.Search(21);
            Console.WriteLine(success);
            Console.ReadLine();
        }
    }
}
