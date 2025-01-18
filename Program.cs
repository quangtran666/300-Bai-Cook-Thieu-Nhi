var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

var result = RemoveNthFromEnd(head, 2);

ListNode RemoveNthFromEnd(ListNode head, int n)
{
    var dummyLength = head;
    var length = 0;
    while (dummyLength != null)
    {
        length++;
        dummyLength = dummyLength.next;
    }
    
    var dummy = new ListNode(0);
    dummy.next = head;
    var prev = dummy;
    var current = head;

    while (length - n > 0)
    {
        prev = current;
        current = current.next;
        length--;
    }
    
    prev.next = current.next;
    return dummy.next;
} 

class ListNode(int val = 0, ListNode next = null)
{
    public int val = val;
    public ListNode next = next;
}