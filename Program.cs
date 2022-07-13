using System;

namespace MergeTwoLists
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = [1,2,4];
            ListNode l2 = [1,3,4];

            Console.WriteLine(MergeTwoLists(l1,l2));
        }

        public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        
            if (l1 == null) return l2;
                if (l2 == null) return l1;

                if (l1.val < l2.val)
                {
                    l1.next = MergeTwoLists(l1.next, l2);
                    return l1;
                }
                else
                {
                    l2.next = MergeTwoLists(l1, l2.next);
                    return l2;
                } 
            
        }
    }
}
