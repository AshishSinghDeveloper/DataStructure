using System;
using System.Collections.Generic;

//Question
//You are given two non-empty linked lists representing two non-negative integers.
//The digits are stored in reverse order and each of their nodes contain a single digit.Add the two numbers and return it as a linked list.
//You may assume the two numbers do not contain any leading zero, except the number 0 itself.

//Example:
//Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
//Output: 7 -> 0 -> 8
//Explanation: 342 + 465 = 807.


namespace AmazonStack
{
    public class AddLinkedListNumber
    {
        //Time: O(n|m) lenght of input linkedlist
        //Space: O(n|m) length of input linkedList
        public class ListNode
        {
            public int val;
            public ListNode next;      
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
        }
    }
}
