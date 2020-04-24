using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.hackerrank.com/challenges/find-the-merge-point-of-two-joined-linked-lists/problem
namespace Merge_Point_of_two_linked_lists
{
    public class Program
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
        static int findMergeNode(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
            SinglyLinkedListNode currentA = head1;
            SinglyLinkedListNode currentB = head2;
            while (currentA != currentB)
            {
                if (currentA.next == null)
                {
                    currentA = head2;
                }
                else
                {
                    currentA = currentA.next;
                }
                if (currentB.next == null)
                {
                    currentB = head1;
                }
                else
                {
                    currentB = currentB.next;
                }
            }
            return currentB.data;
        }
        static void Main(string[] args)
        {
        }
    }
}
