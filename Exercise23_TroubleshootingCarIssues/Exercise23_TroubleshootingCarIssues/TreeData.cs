using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise23_TroubleshootingCarIssues
{
    public class TreeData
    {
        public static BinaryTree<CarIssues> GetTree()
        {
            BinaryTree<CarIssues> tree = new BinaryTree<CarIssues>();
            tree.Root = new BinaryTreeNode<CarIssues>()
            {
                Data = new CarIssues("Is the car slient when " +
                "you turn the key?"),
                Children = new List<TreeNode<CarIssues>>()
                {
                    new BinaryTreeNode<CarIssues>()
                    {
                        Data = new CarIssues("Are the battery" +
                        " terminals corroded?"),
                        Children = new List<TreeNode<CarIssues>>()
                        {
                            new BinaryTreeNode<CarIssues>()
                            {
                                Data = new CarIssues("Clean terminals and try " +
                                "starting again.")
                            },
                            new BinaryTreeNode<CarIssues>()
                            {
                                Data = new CarIssues("Replace cables and try" +
                                " again.")
                            }
                        }
                    },
                    new BinaryTreeNode<CarIssues>()
                    {
                        Data = new CarIssues("Does the car make " +
                        "a clicking noise?"),
                        Children = new List<TreeNode<CarIssues>>()
                        {
                            new BinaryTreeNode<CarIssues>()
                            {
                                Data = new CarIssues("Replace the battery")
                            },
                            new BinaryTreeNode<CarIssues>()
                            {
                                Data = new CarIssues("Does the car crank up " +
                                "but fail to start?"),
                                Children = new List<TreeNode<CarIssues>>()
                                {
                                    new BinaryTreeNode<CarIssues>()
                                    {
                                        Data = new CarIssues("Check spark plug connections")
                                    },
                                    new BinaryTreeNode<CarIssues>()
                                    {
                                        Data = new CarIssues("Does the engine start " +
                                        "and then die?"),
                                        Children = new List<TreeNode<CarIssues>>()
                                        {
                                            new BinaryTreeNode<CarIssues>()
                                            {
                                                Data = new CarIssues("Does your car have " +
                                                "fuel injection?"),
                                                Children = new List<TreeNode<CarIssues>>()
                                                {
                                                    new BinaryTreeNode<CarIssues>()
                                                    {
                                                        Data = new CarIssues("Check to ensure the choke " +
                                                        "is opening and closing")
                                                    },
                                                    new BinaryTreeNode<CarIssues>()
                                                    {
                                                        Data = new CarIssues("Get it in for service.")
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };

            return tree;
        }
    }
}
