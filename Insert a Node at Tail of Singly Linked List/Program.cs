using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.hackerrank.com/challenges/insert-a-node-at-the-tail-of-a-linked-list/problem
namespace Insert_a_Node_at_Tail_of_Singly_Linked_List
{
    class Program
    {
        public class SinglyLinkedListNode
        {
            public int data;
            public SinglyLinkedListNode next;

            public SinglyLinkedListNode(int d)
            {
                this.data = d;
            }
        }
        public static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data)
        {
            SinglyLinkedListNode new_node = new SinglyLinkedListNode(data);
            if (head == null)
            {
                head = new SinglyLinkedListNode(data);
                return head;
            }
            new_node.next = null;
            SinglyLinkedListNode last = head;
            while (last.next != null)
            {
                last = last.next;
            }
            last.next = new_node;
            return head;

        }
        static void Main(string[] args)
        {
        }
    }
}
