public static class LevelOrderTraversalSolution{
    public static IList<IList<int>> LevelOrder(TreeNode root) {
        List<IList<int>> result = new List<IList<int>>();
        if (root == null) return result;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0) {
            int levelLength = queue.Count; // Number of elements at the current level
            List<int> currentLevel = new List<int>();

            for (int i = 0; i < levelLength; i++) {
                TreeNode node = queue.Dequeue(); // Remove the next node from the queue
                currentLevel.Add(node.val); // Process the current node

                // Add the node's children to the queue for the next level
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }

            result.Add(currentLevel); // Add the current level's values to the result list
        }

        return result;
    }
}