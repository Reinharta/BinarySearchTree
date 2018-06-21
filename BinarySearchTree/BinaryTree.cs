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


        public void Add(int newValue)
        {
            AddToTree(root, newValue);
        }
        private void AddToTree(Node currentNode, int newValue)
        {
            if(currentNode == null)
            {
                Node newNode = new Node(newValue);
                currentNode = newNode;
                return;
            }
            if (newValue < currentNode.Value)
            {
                AddToTree(currentNode.LeftChild, newValue);
                return;
            }
            if (newValue > currentNode.Value)
            {
                AddToTree(currentNode.RightChild, newValue);
                return;
            }
            if (newValue == currentNode.Value)
            {
                Console.WriteLine("This value is already present.");
            }
        }

        public Node Search (int value)
        {
            Node foundNode;
            SearchTree(root, value);
            
        }
        public void SearchTree (Node currentNode, int value)
        {
            if (currentNode.Value == value)
            {
                
            }
            if (value > currentNode.Value)
            {
                SearchTree(currentNode.RightChild, value);
            }
            else if (value < currentNode.Value)
            {
                SearchTree(currentNode.LeftChild, value);
                
            }
        }
    }
}
