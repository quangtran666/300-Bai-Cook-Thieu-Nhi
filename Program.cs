var head = new ListNode(3);
head.next = new ListNode(2);
head.next.next = new ListNode(0);
head.next.next.next = new ListNode(-4);
head.next.next.next.next = head.next;

Console.WriteLine(HasCycle(head));

bool HasCycle(ListNode head)
{
    var slow = head;
    var fast = head;

    while (fast != null && fast.next != null)
    {
        slow = slow.next;
        fast = fast.next.next;

        if (slow == fast)
            return true;
    }

    return false;
}

class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val)
    {
        this.val = val;
        next = null;
    }
}