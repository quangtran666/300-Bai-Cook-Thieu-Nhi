var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));

var result = SwapPairs(head);

ListNode SwapPairs(ListNode head) {
    var dummy = new ListNode(0);
    dummy.next = head;
    var previous = dummy;
    var current = head;

    while (current != null && current.next != null)
    {
        var next = current.next;
        current.next = next.next;
        next.next = current;
        previous.next = next;

        current = current.next;
        previous = next.next;
        next = current?.next;
    }
    
    return dummy.next;
}

class ListNode(int val = 0, ListNode next = null)
{
    public int val = val;
    public ListNode next = next;
}