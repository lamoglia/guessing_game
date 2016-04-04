namespace GuessingGame.data
{
    class Tree
    {
        private TreeNode root;

        public Tree()
        {
            //initial guessings
            root = new TreeNode("lives in water", "Shark", "Monkey");
        }

        public TreeNode getRootNode()
        {
            return root;
        }
    }
}
