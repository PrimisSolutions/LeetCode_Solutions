public static class LinkedListCycleSolution {
    public static bool HasCycle(ListNode head) {
        /*
        The key idea here is that we have two pointers, one moving one step at a time through the list and one moving two steps at a time.
        If the list has a cycle, eventually the fast-moving pointer will end up pointing at the same element as the slow-moving pointer.
        If the list terminates, eventually the fast-moving pointer will be null.
        */
        if (head == null) return false;

        // Initialize two pointers, slow starts at the head, and fast starts at the next node
        ListNode slow = head;
        ListNode fast = head.next;

        // Continue looping until the two pointers meet or until the end of the list is reached
        while (slow != fast) {
            // If fast or fast.next is null, we've reached the end of the list without finding a cycle
            if (fast == null || fast.next == null) {
                return false;
            }

            // Move slow one step and fast two steps
            slow = slow.next;
            fast = fast.next.next;
        }

        // If we exit the loop, it means slow and fast have met, indicating a cycle
        return true;
    }
}