using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        private int value;
        private Node parent;
        private Node leftChild;
        private Node rightChild;

        public int Value { get => value; set => this.value = value; }
        public Node Parent { get => parent; set => parent = value; }
        public Node LeftChild { get => leftChild; set => leftChild = value; }
        public Node RightChild { get => rightChild; set => rightChild = value; }

        public Node(int value)
        {           
                this.value = value;
                parent = null;
                leftChild = null;
                rightChild = null;
        }

        }
            



}
