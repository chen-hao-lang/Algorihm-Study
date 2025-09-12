namespace Alogorihm.List
{
    //移除链表元素
    // 给你一个链表的头节点 head 和一个整数 val ，请你删除链表中所有满足 Node.val == val 的节点，并返回 新的头节点 。
    class RemoveElements
    {
        public ListNode Slove(ListNode head, int val)
        {
            //声明一个虚拟头部节点
            ListNode dummyHead = new ListNode(0, head);
            ListNode temp = dummyHead;
            while (temp.next != null)
            {
                if (temp.next.val == val)
                {
                    temp.next = temp.next.next;
                }
                else
                {
                    temp = temp.next;
                }
            }
            return dummyHead.next;
        }
    }
}