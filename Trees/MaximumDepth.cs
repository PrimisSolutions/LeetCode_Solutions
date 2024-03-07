public static class MaximumDepthTreeSolution {
    public static int MaxDepth(TreeNode root){
        if (root == null) {
            // Base case: An empty tree has a depth of 0
            return 0;
        } else {
            // Recursive case: Compute the depth of each subtree
            int leftDepth = MaxDepth(root.left);
            int rightDepth = MaxDepth(root.right);
            // The depth of the tree is the max of the depths of its subtrees, plus one for the root
            return Math.Max(leftDepth, rightDepth) + 1;
        }
    }
}