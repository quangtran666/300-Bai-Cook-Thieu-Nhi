var head = new ListNode(1);
head.next = new ListNode(2);
head.next.next = new ListNode(3);
head.next.next.next = new ListNode(4);
head.next.next.next.next = new ListNode(5);

Console.WriteLine(ReverseList(head));

ListNode ReverseList(ListNode head) {
    ListNode prev = null;
    var current = head;

    while (current != null)
    {
        var next = current.next;
        current.next = prev;
        prev = current;
        current = next;
    }

    return prev;
}

class ListNode(int val = 0, ListNode next = null)
{
    public int val = val;
    public ListNode next = next;
}

