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
            if (root == null) 
                return;
            Display(root.Left);
            System.Console.Write(root.Data + " ");
            Display(root.Right);
            
        }
        public static int Size(Node root)
        {
            if (root == null)
                return 0;
            else
                return (Size(root.Left) + 1 + Size(root.Right));
        }
        public bool SearchNode(Node root, int search)
        {
            bool check = false;
            if (root == null)
                return check;
            SearchNode(root.Left, search);
            if (root.Data == search)
            {
                return check = true;
            }
            SearchNode(root.Right, search);
            if (root.Data == search)
            {
                return check = true;
            }
            return check;
        }
        public void Search()
        {
            Console.WriteLine("Enter a Value Which you want to search");
            int search = Convert.ToInt16(Console.ReadLine());
            if (SearchNode(root, search))
                Console.WriteLine(search + " : Number Found in tree");
            else
                Console.WriteLine(search + " : Number Not Found in tree");
        }
    }
}
