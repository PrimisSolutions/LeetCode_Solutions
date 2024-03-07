public static class ReverseListSolution {
    public static ListNode ReverseList(ListNode head) {
        // Initialize previous node to null, as the new tail will point to null
        ListNode prev = null;
        // Initialize current node to head, to start the iteration from the beginning of the list
        ListNode current = head;
        // Initialize next node to null, it will be used to temporarily store the next node
        ListNode next = null;

        // Iterate through the list until current node is null
        while (current != null) {
            // Temporarily store the next node
            next = current.next;
            // Reverse the current node's pointer to point to the previous node
            current.next = prev;
            // Move the pointers one position ahead:
            // prev moves to current, and current moves to next (the original next)
            prev = current;
            current = next;
        }
        // Once the loop is finished, prev will be pointing at the new head of the reversed list
        return prev;
    }
}