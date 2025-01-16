var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

ReorderList(head);

void ReorderList(ListNode head)
{
    // Find the middle of the list
    var slow = head;
    var fast = head;

    while (fast != null && fast.next != null)
    {
        slow = slow.next;
        fast = fast.next.next;
    }

    // Reverse cái ở sau
    ListNode prev = null;
    var current = slow;

    while (current != null)
    {
        var next = current.next;
        current.next = prev;
        prev = current;
        current = next;
    }
    
    // Merge 2 list

    var first = head;
    var second = prev;
    
    while (second.next != null)
    {
        var firstNext = first.next;
        var secondNext = second.next;

        first.next = second;
        second.next = firstNext;

        first = firstNext;
        second = secondNext;
    }
}

class ListNode(int val = 0, ListNode next = null)
{
    public int val = val;
    public ListNode next = next;
}