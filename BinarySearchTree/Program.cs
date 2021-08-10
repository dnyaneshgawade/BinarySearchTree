using System;
using System.IO;

namespace BinarySearchTree
{
    class Program
    {

        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Insert(56);
            binaryTree.Insert(30);
            binaryTree.Insert(70);
            binaryTree.Insert(22);
            binaryTree.Insert(40);
            binaryTree.Insert(60);
            binaryTree.Insert(95);
            binaryTree.Insert(11);
            binaryTree.Insert(65);
            binaryTree.Insert(3);
            binaryTree.Insert(16);
            binaryTree.Insert(63);
            binaryTree.Insert(67);
            binaryTree.Display(BinaryTree.root);
            Console.WriteLine("The number of nodes in BST:", BinaryTree.Size(BinaryTree.root));
            binaryTree.Search();
        }
    }
}
