namespace GuessingGame.data
{
   public class Tree
    {
        private TreeNode root;

        /// <summary>
        /// Creates a tree with the initial guessings
        /// </summary>
        /// <param name="animalTrait"></param>
        /// <param name="animalWithTrait"></param>
        /// <param name="animalWithoutTrait"></param>
        public Tree(string animalTrait, string animalWithTrait, string animalWithoutTrait)
        {
            root = new TreeNode(animalTrait, animalWithTrait, animalWithoutTrait);
        }

        public TreeNode getRootNode()
        {
            return root;
        }
    }
}
