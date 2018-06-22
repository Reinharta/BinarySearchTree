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
            BinaryTree newTree = new BinaryTree();
            newTree.Add(4);
            newTree.Add(2);
            newTree.Add(1);
            newTree.Add(6);
            newTree.Add(5);
            newTree.Add(4);
            bool findValue = newTree.Search(3);
            Console.WriteLine(findValue);
            Console.ReadKey();
        }
    }
}
