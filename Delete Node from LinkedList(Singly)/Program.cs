using System;
//https://www.hackerrank.com/challenges/delete-a-node-from-a-linked-list/problem
namespace Delete_Node_from_LinkedList_Singly_
{
    public class Program
    {
        public class SinglyLinkedListNode
        {
            public int data;
            public SinglyLinkedListNode next;
        }
        static SinglyLinkedListNode deleteNode(SinglyLinkedListNode head, int position)
        {
            SinglyLinkedListNode p = head;
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return head;
            }
            else
            {
                if (position == 0)
                {

                    head = head.next;
                    p = null;
                    return head;
                }
                SinglyLinkedListNode q = null;
                for (Int32 i = 0; i < position; i++)
                {
                    q = p;
                    p = p.next;
                }
                q.next = p.next;
                p = null;
                return head;
            }

        }

        static void Main(string[] args)
        {
        }
    }
}
