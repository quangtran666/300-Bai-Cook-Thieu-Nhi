var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

var result = MergeTwoLists(list1, list2);

ListNode MergeTwoLists(ListNode list1, ListNode list2)
{
    if (list1 == null) return list2;
    if (list2 == null) return list1;
    var head1 = list1;
    var head2 = list2;
    
    var dummy = new ListNode();
    if (head1.val < head2.val) {
        dummy.val = head1.val;
        head1 = head1.next;
    }
    else
    {
        dummy.val = head2.val;
        head2 = head2.next;
    }
    
    var tail = dummy;
    while (head1 != null && head2 != null)
    {
        if (head1.val < head2.val)
        {
            tail.next = head1;
            head1 = head1.next;
        }
        else
        {
            tail.next = head2;
            head2 = head2.next;
        }
        tail = tail.next;
    }

    while (head1 != null)
    {
        tail.next = head1;
        head1 = head1.next;
        tail = tail.next;
    }
    
    while (head2 != null)
    {
        tail.next = head2;
        head2 = head2.next;
        tail = tail.next;
    }
    
    return dummy;
}


class ListNode(int val = 0, ListNode next = null)
{
    public int val = val;
    public ListNode next = next;
}