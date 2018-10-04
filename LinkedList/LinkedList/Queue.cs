using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Developer:  Frankie Barrios
/// Date:       10/4/2018
/// Purpose:    Create a class to represent a linked-based Queue.  
///             Use your Linked List code, without its main method,
///             as the underlying storage for your Queue's data.---Done
///             
///             Create one data member in your class: a reference to
///             a LinkedList class object.  The class should also define
///             at least one constructor method in addition to the following
///             methods: Enqueue, Dequeue, Peek.---Done
///             
///             Create a main method to test you queue.---Done
/// </summary>
namespace LinkedListProject
{
    class Queue
    {
        #region Class Fields
        private LLnode _head;
        private LLnode _end;
        private int _count = 0;

        #endregion Class Fields
        public Queue() { }

        #region Methods
        public void Enqueue(int data)
        {
            LLnode _newNode = new LLnode (data);
            if (_head == null)
            {
                _head = _newNode;
                _end = _head;
            }//End of if
            else
            {
                _end.Next = _newNode;
                _end = _end.Next;
            }//End of else
            _count++;
        }//End of public void Enqueue(int data)

        public int Dequeue()
        {
            if (_head == null)
            {
                throw new Exception("Queue is Empty");
            }//End of if
            int _result = _head.Data;
            _head = _head.Next;
            return _result;
        }//End of public int Dequeue()


        public void Peek()
        {
            if (_head == null)
            {
                Console.WriteLine("The Queue is Empty");
                return;
            }//End of if (_head == null)
                Console.WriteLine("{0} is at the beginning of the Queue", this._head.Data);
        }//End of public void Peek()

        #endregion Methods

        #region Constructors/ Getters and Setters
        public int Count1 { get => _count; set => _count = value; }

        public Queue(int count)
        {
            _count = count;
        }//End of public Queue(int count)

        public int Count
        {
            get
            {
                return this._count;
            }
        }//End of public int Coun
        #endregion Constructors/ Getters and Setters
    }
}
