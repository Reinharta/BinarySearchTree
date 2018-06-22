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
        internal Node leftChild;
        internal Node rightChild;

        public int Value { get => value; set => this.value = value; }
        public Node LeftChild { get => leftChild; set => leftChild = value; }
        public Node RightChild { get => rightChild; set => rightChild = value; }

        public Node(int value)
        {           
                this.value = value;
                leftChild = null;
                rightChild = null;
        }

        }
            



}
