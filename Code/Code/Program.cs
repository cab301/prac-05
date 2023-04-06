using BSTreeClass;
using BSTreeInterface;

namespace Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initially, an empty BST is created");
            IBSTree customerBST = new BSTree();

            Customer customer1 = new Customer("John", "Smith", "12345");
            Customer customer2 = new Customer("Mary", "Jane", "23456");
            Customer customer3 = new Customer("Alex", "May", "34567");
            Customer customer4 = new Customer("Bob", "Lee", "34567");
            Customer customer5 = new Customer("Charles", "Boyle", "34567");

            Console.WriteLine("Adding {0} to the BST", customer1);
            customerBST.Insert(customer1);
            Console.WriteLine("Adding {0} to the BST", customer2);
            customerBST.Insert(customer2);
            Console.WriteLine("Adding {0} to the BST", customer3);
            customerBST.Insert(customer3);
            Console.WriteLine("Adding {0} to the BST", customer4);
            customerBST.Insert(customer4);
            Console.WriteLine("Adding {0} to the BST", customer5);
            customerBST.Insert(customer5);

            customerBST.PreOrderTraverse();
            customerBST.InOrderTraverse();
            customerBST.PostOrderTraverse();

            Console.WriteLine();

            Console.WriteLine("Deleting {0} from the BST", customer3);
            customerBST.Delete(customer3);

            customerBST.PreOrderTraverse();
            customerBST.InOrderTraverse();
            customerBST.PostOrderTraverse();

            Console.WriteLine();

            Console.WriteLine("Adding {0} back to the BST", customer3);
            customerBST.Insert(customer3);

            // Delete customer 1, who is the root
            Console.WriteLine("Removing {0} from the BST", customer1);
            customerBST.Delete(customer1);

            customerBST.PreOrderTraverse();
            customerBST.InOrderTraverse();
            customerBST.PostOrderTraverse();
        }

        static void TestBSTCharacters()
        {
            // build a binary search tree
            Console.WriteLine("Initially, an empty BST is created");
            IBSTree aBSTree = new BSTree();

            Console.WriteLine("Adding M to the BST");
            aBSTree.Insert('M');
            Console.WriteLine("Adding M to the BST");
            aBSTree.Insert('D');
            Console.WriteLine("Adding M to the BST");
            aBSTree.Insert('G');
            Console.WriteLine("Adding M to the BST");
            aBSTree.Insert('A');
            Console.WriteLine("Adding M to the BST");
            aBSTree.Insert('W');
            Console.WriteLine("Adding M to the BST");
            aBSTree.Insert('P');
            Console.WriteLine("Adding M to the BST");
            Console.WriteLine();
            Console.WriteLine();

            // pre-order traversal
            aBSTree.PreOrderTraverse();
            // in-order traversal

            aBSTree.InOrderTraverse();
            // post-order traversal

            aBSTree.PostOrderTraverse();

            Console.WriteLine();
            Console.WriteLine();

            // delete a leaf A

            aBSTree.Delete('A');
            Console.WriteLine("A has been deleted from the BST");
            Console.WriteLine();
            Console.WriteLine();

            // pre-order traversal

            aBSTree.PreOrderTraverse();
            // in-order traversal

            aBSTree.InOrderTraverse();
            // post-order traversal

            aBSTree.PostOrderTraverse();

            Console.WriteLine();
            Console.WriteLine();

            // put A back aBStree
            aBSTree.Insert('A');
            Console.WriteLine("A has been added back to the BST");
            // delete a node W, which has only one child
            aBSTree.Delete('W');
            Console.WriteLine("W has been deleted from the BST");
            Console.WriteLine();
            Console.WriteLine();

            // pre-order traversal

            aBSTree.PreOrderTraverse();
            // in-order traversal

            aBSTree.InOrderTraverse();
            // post-order traversal

            aBSTree.PostOrderTraverse();

            Console.WriteLine();
            Console.WriteLine();

            // clear the binary tree
            aBSTree.Clear();
            Console.WriteLine("The BST has been cleard");
            Console.WriteLine();
            Console.WriteLine();

            // pre-order traversal

            aBSTree.PreOrderTraverse();
            // in-order traversal

            aBSTree.InOrderTraverse();
            // post-order traversal

            aBSTree.PostOrderTraverse();

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}