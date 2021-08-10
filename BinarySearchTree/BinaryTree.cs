using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class BinaryTree
    {
        public static  Node root;
        public BinaryTree()
        {
            root = null;
        }
        public void Insert(int i)
        {
            Node newNode = new Node
            {
                Data = i
            };
            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (i < current.Data)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }

                        else
                        {
                            current = current.Right;
                            if (current == null)
                            {
                                parent.Right = newNode;
                                break;
                            }
                        }
                    }
                }
            }
        }
        public void Display(Node root)
        {
            if (root != null)
            {
                Display(root.Left);
                Display(root.Right);
                Console.WriteLine(root.Data);
            }
        }
    }
}
