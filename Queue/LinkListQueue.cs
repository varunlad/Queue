using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class LinkListQueue
    {
        Node head;
        /// <summary>
        /// Enqueues the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void Enqueue(int item)
        {
            Node new_node = new Node(item);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new_node;
            }
            Console.WriteLine("Inserted int list" + new_node.data);
        }
        public void Dequeue()
        {
            //If queue is empty,return NULL.
            if (this.head == null)
            {
                Console.WriteLine("the Queue is empty");
                return;
            }
            //store previous head and move head pointer one step ahead to delete the current element
            Node temp = this.head;
            this.head = this.head.next;
            Console.WriteLine("Item deleted is {0}", temp.data);
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;

            }
            else
            {
                while (temp != null)
                {
                    Console.Write(" " + temp.data);
                    temp = temp.next;
                }

            }
        }
    }
}
