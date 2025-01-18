var head = new ListNode(1, new ListNode(4, new ListNode(3, new ListNode(2, new ListNode(5, new ListNode(2))))));

var result = Partition(head, 3);

ListNode Partition(ListNode head, int x) {
    var before = new ListNode(0);
    var after = new ListNode(0);
    var beforeHead = before;
    var afterHead = after;

    while (head != null)
    {
        if (head.val < x)
        {
            beforeHead.next = head;
            beforeHead = beforeHead.next;
        }
        else
        {
            afterHead.next = head;
            afterHead = afterHead.next;
        }
        head = head.next;
    }

    afterHead.next = null;
    beforeHead.next = after.next;
    
    return before.next;
}

class ListNode(int val = 0, ListNode next = null)
{
    public int val = val;
    public ListNode next = next;
}