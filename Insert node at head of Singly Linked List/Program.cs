using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.hackerrank.com/challenges/insert-a-node-at-the-head-of-a-linked-list/problem
namespace Insert_node_at_head_of_Singly_Linked_List
{
    public class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;
    }
    class Program
    {

        public static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode head)
        {
            SinglyLinkedListNode newnode = new SinglyLinkedListNode();
            newnode.next = head;
            head = newnode;
            return head;
        }
        static void Main(string[] args)
        {
        }
    }

}

