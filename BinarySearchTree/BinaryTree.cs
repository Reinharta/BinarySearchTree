using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree
    {
        private Node root;


        public Node Root { get => root; } 


        public BinaryTree()
        {
            root = null;
        }
        public BinaryTree(int initialValue)
        {
            root = new Node(initialValue);
        }


        // NON-RECURSIVE ADD()


        //public void Add(int newValue)
        //{
        //    bool added = false;
        //    if(root == null)
        //    {
        //        Node newNode = new Node(newValue);
        //        root = newNode;
        //        added = true;
        //        return;
        //    }

        //    Node currentNode = root;
        //    while (added == false)
        //    {
        //        if (newValue == currentNode.Value)
        //        {
        //            Console.WriteLine("{0} is already present.", newValue);
        //            return;
        //        }
        //        if (newValue < currentNode.Value)
        //        {
        //            if (currentNode.LeftChild == null)
        //            {
        //                Node newNode = new Node(newValue);
        //                currentNode.LeftChild = newNode;
        //                added = true;
        //            }
        //            else
        //            {
        //                currentNode = currentNode.LeftChild;
        //            }
        //        }
        //        if (newValue > currentNode.Value)
        //        {
        //           if (currentNode.RightChild == null)
        //            {
        //                Node newNode = new Node(newValue);
        //                currentNode.RightChild = newNode;
        //                added = true;
        //            }
        //           else
        //            {
        //                currentNode = currentNode.RightChild;
        //            }
        //        }
        //    }
        //}


        // RECURSIVE ADD()

        public void Add(int newValue)
        {
            AddToTree(ref root, newValue);
        }
        private void AddToTree(ref Node currentNode, int newValue)
        {
            if(currentNode == null)
            {
                Node newNode = new Node(newValue);
                currentNode = newNode;
                return;
            }
            if (newValue<currentNode.Value)
            {
                AddToTree(ref currentNode.leftChild, newValue);
                return;
            }
            if (newValue > currentNode.Value)
            {
                AddToTree(ref currentNode.rightChild, newValue);
                return;
            }
            if (newValue == currentNode.Value)
            {
                Console.WriteLine("{0} is already present.", newValue);
                return;
            }
        }


        public bool Search (int value)
        {
            bool nodeFound = false;
            Node currentNode = root;

            while (nodeFound == false)
            {
                if (currentNode == null)
                {
                    return nodeFound;
                }
                if (value == currentNode.Value)
                {
                    nodeFound = true;
                }
                else if(value < currentNode.Value)
                {
                    if (currentNode.LeftChild == null)
                    {
                        return nodeFound;
                    }
                    if(currentNode.LeftChild.Value == value)
                    {
                        nodeFound = true;
                    }
                    else
                    {
                        currentNode = currentNode.LeftChild;
                    }
                }

                else if(value > currentNode.Value)
                {
                    if(currentNode.RightChild == null)
                    {
                        return nodeFound;
                    }
                    if(currentNode.RightChild.Value == value)
                    {
                        nodeFound = true;
                    }
                    else
                    {
                        currentNode = currentNode.RightChild;
                    }
                }

            } 
            return nodeFound;
        }
    }
}
