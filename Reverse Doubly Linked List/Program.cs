using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//https://www.hackerrank.com/challenges/reverse-a-doubly-linked-list/problem
namespace Reverse_Doubly_Linked_List
{


    public class DoublyLinkedListNode
    {
        int data;
        public DoublyLinkedListNode next;
        public DoublyLinkedListNode prev;
    }


    class Program
    {
        static DoublyLinkedListNode reverse(DoublyLinkedListNode head)
        {
            DoublyLinkedListNode temp = null;
            DoublyLinkedListNode p = head;
            if (p == null)
            {
                return null;
            }
            else if (p.next == null)
            {
                p = head;
                return head;
            }
            while (p != null)
            {
                temp = p.prev;
                p.prev = p.next;
                p.next = temp;
                p = p.prev;
            }
            if (temp != null)
            {
                temp = temp.prev;
            }
            return temp;

        }

        static void Main(string[] args)
        {
        }
    }
}
