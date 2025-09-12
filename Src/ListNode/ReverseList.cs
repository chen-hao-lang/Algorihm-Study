using System.Text.RegularExpressions;

namespace Alogorihm.List
{
    /// <summary>
    /// 反转链表
    /// </summary>
    class ReverseList
    {
        public ListNode Slove(ListNode head)
        {
            //声明一个指针指向当前头部
            //声明一个空指针用来存后面的指针
            //声明一个方向指针
            ListNode cur = head;
            ListNode temp;
            ListNode pre = null;

            while (cur != null)
            {
                temp = cur.next;//先把后面的节点存起来
                cur.next = pre;//把当前节点的下一个节点指向前一个节点
                pre = cur;//把前一个节点指向当前节点
                cur = temp;//把当前节点指向后一个节点
            }

            return pre;
        }
    }
}