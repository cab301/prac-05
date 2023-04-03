using BSTreeClass;

namespace Customers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Make a collection of capacity 3
            //CustomerCollection collection = new CustomerCollection(3);
            //collection.Insert("Ryan", "Reynolds", "123456");
            //collection.Insert("Dan", "Tran", "456789");
            //collection.Insert("Maolin", "Tang", "234567");
            //collection.Display();

            //Console.WriteLine();

            //collection.Sort();
            //Console.WriteLine("The collection has been sorted");

            //collection.Display();

            BSTree customerBSTree = new BSTree();
            Customer customer1 = new Customer("Ryan", "Reynolds", "123456");
            Customer customer2 = new Customer("Dan", "Tran", "456789");
            Customer customer3 = new Customer("Maolin", "Tang", "234567");

            customerBSTree.Insert(customer1);
            customerBSTree.Insert(customer2);
            customerBSTree.Insert(customer3);

            customerBSTree.PreOrderTraverse();
            customerBSTree.InOrderTraverse();
            customerBSTree.PostOrderTraverse();
        }
    }
}