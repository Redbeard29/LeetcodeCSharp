//You are given the heads of two sorted lists list1 and list2. Merge the two lists into one
//sorted list. The list should be made by splicing together the nodes of the first two
//lists. Return the head of the merged linked list. Definition of the linked list is in 
//the listNode.cs file
//Ex: Input -> list1 = [1, 2, 4], list2 = [1, 3, 4] Output -> [1, 1, 2, 3, 4, 4];
//Ex2: Input -> list1 = [], list2 = [0] Output -> [0]

using System;

namespace CSharp{

    public class mergeTwoSortedLists{
        public static ListNode MergeTwoSortedLists(ListNode list1, ListNode list2){
            ListNode dummy = new ListNode(-1);

            ListNode prev = dummy;

            while(list1 != null && list2 != null){
                if(list1.val <= list2.val){
                    prev.next = list1;
                    list1 = list1.next;
                }
                else{
                    prev.next = list2;
                    list2 = list2.next;
                }
                prev = prev.next;
            }

            if(list1 == null){
                prev.next = list2;
            }
            else{
                prev.next = list1;
            }

            return dummy.next;
        }
    }
}