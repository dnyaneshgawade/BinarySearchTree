using System;
using System.IO;

namespace BinarySearchTree
{
    class Program
    {

        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Insert(45);
            binaryTree.Insert(1);
            binaryTree.Insert(23);
            binaryTree.Display(BinaryTree.root);

        }
    }
}
