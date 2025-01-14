var head = new ListNode(1);
head.next = new ListNode(2);
head.next.next = new ListNode(2);
head.next.next.next = new ListNode(1);

Console.WriteLine(IsPalindrome(head));

bool IsPalindrome(ListNode head)
{
    var fast = head;
    var slow = head;

    while (fast != null && fast.next != null)
    {
        slow = slow.next;
        fast = fast.next.next;
    }

    ListNode prev = null;
    var curr = slow;

    while (curr != null)
    {
        var next = curr.next;
        curr.next = prev;
        prev = curr;
        curr = next;
    }

    while (prev != null && head != null)
    {
        if (prev.val != head.val)
            return false;
        prev = prev.next;
        head = head.next;
    }

    return true;
}

class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}