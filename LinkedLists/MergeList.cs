public static class MergeLinkedList {
    public static ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        // Initialize a dummy node to start the new list
        ListNode dummy = new ListNode(0);
        // Use current node to track the end of the new list as we build it
        ListNode current = dummy;

        // Iterate as long as both lists have elements
        while (list1 != null && list2 != null) {
            // Compare the current nodes of both lists
            if (list1.val < list2.val) {
                // If list1's node is smaller, attach it to the new list
                current.next = list1;
                // Move list1's pointer forward
                list1 = list1.next;
            } else {
                // If list2's node is smaller or equal, attach it to the new list
                current.next = list2;
                // Move list2's pointer forward
                list2 = list2.next;
            }
            // Move the current pointer forward in the new list
            current = current.next;
        }

        // If there are remaining elements in either list, attach the entire remainder to the new list
        if (list1 != null) {
            current.next = list1;
        } else if (list2 != null) {
            current.next = list2;
        }

        // The dummy node's next pointer points to the start of the merged list
        return dummy.next; 
    }
}