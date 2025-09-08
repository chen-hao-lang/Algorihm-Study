namespace Alogorihm.List
{
    /// <summary>
    /// 两两交换列表中的节点
    /// </summary>
    class SwapPairs
    {
        public ListNode Slove(ListNode head)
        {
            //声明一个虚拟头节点
            ListNode dummyHead = new ListNode(0);
            dummyHead.next = head;
            ListNode cur = dummyHead;

            while (cur.next != null && cur.next.next != null)
            {
                ListNode first = cur.next;
                ListNode second = cur.next.next;

                first.next = second.next;
                second.next = first;
                cur.next = second;
                cur = first;
            }

            // while (cur.next != null && cur.next.next != null)
            // {
            //     ListNode temp1 = cur.next;
            //     ListNode temp2 = cur.next.next.next;

            //     cur.next = cur.next.next;
            //     cur.next.next = temp1;
            //     cur.next.next.next = temp2;

            //     cur = cur.next.next;
            // }

            return dummyHead.next;
        }
    }
}