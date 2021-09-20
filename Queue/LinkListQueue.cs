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
