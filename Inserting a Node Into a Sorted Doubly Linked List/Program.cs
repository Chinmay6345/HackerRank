using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.hackerrank.com/challenges/insert-a-node-into-a-sorted-doubly-linked-list/problem
namespace Inserting_a_Node_Into_a_Sorted_Doubly_Linked_List
{
    public class Program
    {
        public class DoublyLinkedListNode
        {
            public int data;
            public DoublyLinkedListNode next;
            public DoublyLinkedListNode prev;

            public DoublyLinkedListNode(int d)
            {
                this.data = d;
            }
        }
        static DoublyLinkedListNode sortedInsert(DoublyLinkedListNode head, int data)
        {
            DoublyLinkedListNode newNode = new DoublyLinkedListNode(data);
            newNode.prev = null;
            newNode.next = null;
            if (head == null)
            {
                return newNode;
            }
            if (data < head.data)
            {
                newNode.next = head;
                head.prev = newNode;
                head = newNode;
                return head;
            }
            else
            {
                DoublyLinkedListNode p = head;
                DoublyLinkedListNode q = null;
                while (p != null && p.data < data)
                {
                    q = p;
                    p = p.next;
                }
                if (p == null)
                {
                    q.next = newNode;
                    newNode.prev = q;
                }
                else
                {
                    q.next = newNode;
                    p.prev = newNode;
                    newNode.prev = q;
                    newNode.next = p;
                }
                return head;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
