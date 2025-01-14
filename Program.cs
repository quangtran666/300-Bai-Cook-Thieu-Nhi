var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

var result = MergeTwoLists(list1, list2);

ListNode MergeTwoLists(ListNode list1, ListNode list2)
{
    var dummy = new ListNode(0);
    var node = dummy;

    while (list1 != null && list2 != null) {
        if (list1.val < list2.val) {
            node.next = list1;
            list1 = list1.next;
        } else {
            node.next = list2;
            list2 = list2.next;
        }
        node = node.next;
    }

    if (list1 != null) {
        node.next = list1;
    } else {
        node.next = list2;
    }

    return dummy.next;
}


class ListNode(int val = 0, ListNode next = null)
{
    public int val = val;
    public ListNode next = next;
}