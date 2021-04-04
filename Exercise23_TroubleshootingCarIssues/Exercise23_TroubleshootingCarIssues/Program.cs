using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise23_TroubleshootingCarIssues
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<CarIssues> tree = TreeData.GetTree();
            BinaryTreeNode<CarIssues> node = tree.Root;

            while (node != null)
            {
                if (node.Left != null || node.Right != null)
                {
                    Console.Write(node.Data.Text);
                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.Y:
                            WriteAnswer(" Yes");
                            node = node.Left;
                            break;
                        case ConsoleKey.N:
                            WriteAnswer(" No");
                            node = node.Right;
                            break;
                    }
                }
                else
                {
                    WriteAnswer(node.Data.Text);
                    node = null;
                }
            }

            Console.ReadKey();
        }

        private static void WriteAnswer(string text)
        {
            Console.WriteLine(text);
        }
    }
}
