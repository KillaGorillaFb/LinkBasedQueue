using static System.Console;

/// <summary>
/// Developer:  Frankie Barrios
/// Date:       9/27/18 - 10/4/18
/// Purpose:    Class Tester
/// </summary>
namespace LinkedListProject
{
    class Driver
    {
        static void Main(string[] args)
        {
            //Need to implement tester here for Queue Class
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(9);
            queue.Enqueue(8);
            queue.Enqueue(7);
            queue.Enqueue(6);
            queue.Peek();
            ReadKey();

            //Not using for this Main code from Linked List for this project
            //Should add nodes in order
            //LinkedList list = new LinkedList();
            //list.AddEnding(10);
            //list.AddEnding(9);
            //list.AddEnding(8);
            //list.AddEnding(7);
            ////Since adding to front with each iteration, should add these particular values as if in desc order
            //list.AddToFront(1);
            //list.AddToFront(2);
            //list.AddToFront(3);
            //list.AddToFront(4);

            //list.Print();
            //ReadKey();         
        }//End of Main
    }//End of Class
}//End of Solution
