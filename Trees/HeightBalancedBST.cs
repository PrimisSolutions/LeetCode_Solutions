public static class HeightBalancedBSTSolution{
    public static TreeNode SortedArrayToBST(int[] nums) {
        // Start the recursive tree construction
        return SortedArrayToBSTHelper(nums, 0, nums.Length - 1);    
    }
    
    private static TreeNode SortedArrayToBSTHelper(int[] nums, int left, int right) {
        // Base case: leaf nodes
        if (left > right) return null;

        // Find the middle element to make the root of the BST
        // Using (left + right) / 2 could potentially cause overflow, so we use left + (right - left) / 2
        int mid = left + (right - left) / 2;

        // Create the current node with the middle element
        TreeNode node = new TreeNode(nums[mid]);

        // Recursively construct the left and right subtrees
        node.left = SortedArrayToBSTHelper(nums, left, mid - 1);
        node.right = SortedArrayToBSTHelper(nums, mid + 1, right);

        return node;
    }
}