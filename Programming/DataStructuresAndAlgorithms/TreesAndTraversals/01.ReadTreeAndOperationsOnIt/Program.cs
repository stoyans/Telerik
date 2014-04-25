using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTreeAndOperationsOnIt
{
    class Program
    {

        static int FindRoot(TreeNode<int>[] nodes)
        {
            for (int i = 0; i < nodes.Length; i++)
            {
                foreach (var child in nodes[i].Children)
                {
                    child.isParent = true;
                }
            }

            foreach (var child in nodes)
            {
                if (child.isParent == false)
                {
                    return child.Value;
                }
            }

            throw new ArgumentException("The tree has no root.");
        }

        static List<int> FindAllLeafs(TreeNode<int>[] nodes)
        {
            List<int> leafNodes = new List<int>();

            foreach (var node in nodes)
            {
                if (node.Children.Count == 0)
                {
                    leafNodes.Add(node.Value);
                }
            }

            return leafNodes;
        }

        static List<int> FindAllMiddleNodes(TreeNode<int>[] nodes)
        {
            List<int> middleNodes = new List<int>();

            foreach (var node in nodes)
            {
                if (node.Children.Count > 0 && node.isParent == true)
                {
                    middleNodes.Add(node.Value);
                }
            }

            return middleNodes;
        }


        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            var nodes = new TreeNode<int>[N];

            for (int i = 0; i < N; i++)
            {
                nodes[i] = new TreeNode<int>(i);
            }

            for (int i = 1; i <= N - 1; i++)
            {
                string input = Console.ReadLine();
                var splitInput = input.Split(' ');

                int parent = int.Parse(splitInput[0]);
                int child = int.Parse(splitInput[1]);

                nodes[parent].Children.Add(nodes[child]);
            }

            //Task 1:
            int root = FindRoot(nodes);
            Console.WriteLine("The root of the tree is: {0}", root);

            //Task 2:
            var leafs = FindAllLeafs(nodes);
            Console.Write("All leafs in the tree are: ");
            foreach (var leaf in leafs)
            {
                Console.Write(leaf + " ");
            }
            Console.WriteLine();

            //Task 3:
            var middleNodes = FindAllMiddleNodes(nodes);
            Console.Write("All leafs in the tree are: ");
            foreach (var midNodes in middleNodes)
            {
                Console.Write(midNodes + " ");
            }
            Console.WriteLine();


        }
    }
}
