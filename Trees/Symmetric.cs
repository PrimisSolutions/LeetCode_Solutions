public static class SymmetricTreeNodeSolution {
    public static bool IsSymmetric(TreeNode root) {
        if (root == null) return true;
        return IsMirror(root.left, root.right);
    }
    
    private static bool IsMirror(TreeNode left, TreeNode right) {
        // If both subtrees are null, they are mirror images
        if (left == null && right == null) return true;
        // If one subtree is null, but the other isn't, they aren't mirror images
        if (left == null || right == null) return false;
        // Two subtrees must have the same root value and their children must be mirror images
        return (left.val == right.val) && IsMirror(left.right, right.left) && IsMirror(left.left, right.right);
    }
}