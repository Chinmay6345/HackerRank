using System;

//https://www.hackerrank.com/challenges/reverse-a-linked-list/problem?h_r=internal-search
namespace Reverse_Linked_List
{
    // Complete the reverse function below.


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public class AppHelper
    {
        public Int32 GetCountOfElements(ListNode head)
        {
            ListNode p = head;
            Int32 count = 0;
            while (p != null)
            {
                count = count + 1;
                p = p.next;
            }
            return count;
        }
        public ListNode ReversedLinkedList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            Int32 count = GetCountOfElements(head);
            Int32[] arr = new Int32[count];
            Int32 i = 0;
            ListNode p = head;
            while (p != null)
            {
                arr[i] = p.val;
                i = i + 1;
                p = p.next;
            }
            Array.Reverse(arr);
            i = 0;
            p = head;
            while (p != null)
            {
                p.val = arr[i];
                p = p.next;
                i = i + 1;
            }
            return head;
        }
        public void ReverseUsingPointers(ListNode head)
        {
            ListNode p = head;
            ListNode q = null;
            ListNode r = null;
            while(p!=null)
            {
                r = q;
                q = p;
                p = p.next;
                q.next = r;
            }
        }
    }

    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            AppHelper helper = new AppHelper();
            return helper.ReversedLinkedList(head);
        }
    }
}
