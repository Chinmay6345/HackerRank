using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.hackerrank.com/challenges/insert-a-node-at-a-specific-position-in-a-linked-list/problem

namespace Insert_Node_at_specified_position
{
    class Program
    {
        public class SinglyLinkedListNode
        {
            public int data;
            public SinglyLinkedListNode next;
        }
        public static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode head,
                                                     int data, int position)
        {
            SinglyLinkedListNode p = head;
            SinglyLinkedListNode newnode = new SinglyLinkedListNode();
            if (position == 0)
            {
                newnode.next = head;
                head = newnode;
                return head;
            }
            else
            {
                for (Int32 i = 0; i < position - 1; i++)
                {
                    p = p.next;
                }
                newnode.next = p.next;
                p.next = newnode;
                return head;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
