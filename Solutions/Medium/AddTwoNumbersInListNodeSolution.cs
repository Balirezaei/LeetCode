using System.Collections.Generic;

namespace Solutions.Medium
{

    public class AddTwoNumbersInListNodeSolution
    {

        /// <summary>
        /// Input: l1 = [2,4,3], l2 = [5,6,4]
        /// Output: [7,0,8]
        /// Explanation: 342 + 465 = 807.
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            string result = "";
            int carry = 0;

            while (l1 != null || l2 != null || carry != 0)
            {
                int sum = ((l2 == null) ? 0 : l2.val) + ((l1 == null) ? 0 : l1.val) + carry;
                result +=   (sum % 10).ToString();
                carry = sum / 10;

                l1 = (l1 == null) ? l1 : l1.next;
                l2 = (l2 == null) ? l2 : l2.next;
            }

            return InputToListNode(result);

        }



        public ListNode InputToListNode(string input)
        {
            ListNode result = new ListNode(int.Parse(input.Substring(0, 1)), null);
            if (input.Substring(0).Length > 1)
            {
                result.next = InputToListNode(input.Substring(1));
            }

            return result;
        }

 
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

}