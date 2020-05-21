using System;
using System.Collections.Generic;

namespace AmazonStack
{
    public class AddLinkedListNumber
    {
        public AddLinkedListNumber()
        {
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            //public ListNode(int val = 0, ListNode next = null)
            //{
            //    this.val = val;
            //    this.next = next;
            //}            
        }
        public class Solution
        {
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                ListNode result = new ListNode();
                ListNode temp = result;
                int carry = 0;

                while (l1 != null || l2 != null)
                {
                    int l1num = (l1 != null) ? l1.val : 0;
                    int l2num = (l2 != null) ? l2.val : 0;

                    int sum = l1num + l2num + carry;
                    carry = sum / 10;

                    ListNode newNode = new ListNode();
                    newNode.val = sum % 10;

                    temp.next = newNode;
                    temp = temp.next;

                    if (l1 != null) l1 = l1.next;
                    if (l2 != null) l2 = l2.next;
                }
                if (carry == 1)
                {
                    ListNode carryNode = new ListNode();
                    carryNode.val = 1;
                    //carryNode.next = null;
                    temp.next = carryNode;

                }
                return result.next;
            }

        //    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        //    {
        //        ListNode result = new ListNode();
        //        ListNode temp = result;
        //        int carry = 0;

        //        while (l1 != null || l2 != null)
        //        {
        //            int l1num = (l1 != null) ? l1.val : 0;
        //            int l2num = (l2 != null) ? l2.val : 0;

        //            int sum = l1num + l2num + carry;
        //            carry = sum / 10;

        //            temp.next = new ListNode(sum % 10);
        //            temp = temp.next;

        //            if (l1 != null) l1 = l1.next;
        //            if (l2 != null) l2 = l2.next;
        //        }
        //        if (carry == 1)
        //        {
        //            temp.next = new ListNode(1);
        //        }
        //        return result.next;
        //    }
        }
    }
}
